#include <SoftwareSerial.h>
#include <dht.h>

#define dataPin 2
dht DHT;

unsigned int pm1 = 0;
unsigned int pm2_5 = 0;
unsigned int pm10 = 0;
float tab [5];
void setup() {
  Serial.begin(9600);

}

void loop() {
int index = 0;
char value;
char previousValue;

 int readData = DHT.read22(dataPin);
 float temperatura = DHT.temperature;
 float wilgotnosc = DHT.humidity;
  while (Serial.available()) {
    value = Serial.read();
    if ((index == 0 && value != 0x42) || (index == 1 && value != 0x4d)){
      break;
    }

    if (index == 4 || index == 6 || index == 8 || index == 10 || index == 12 || index == 14) {
      previousValue = value;
    }
    else if (index == 5) {
      pm1 = 256 * previousValue + value;
      tab[0] = pm1;
    }
    else if (index == 7) {
      pm2_5 = 256 * previousValue + value;
      tab[1] = pm2_5;
    }
    else if (index == 9) {
      pm10 = 256 * previousValue + value;
      tab[2] = pm10;
    } 
    
    index++;
   
  tab[3] = temperatura;
  tab[4] = wilgotnosc;
  }
  delay(600);
  for(int i = 0; i<5; i++)
  {
    Serial.print(tab[i]);
    Serial.print(";");
  }
  
}
