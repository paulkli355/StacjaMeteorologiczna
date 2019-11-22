#include <SoftwareSerial.h>
#include <dht.h>

#define dataPin 2
dht DHT;

unsigned int pm1 = 0;
unsigned int pm2_5 = 0;
unsigned int pm10 = 0;

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
      //Serial.println("Cannot find the data header.");
      Serial.println(" ");
      break;
    }

    if (index == 4 || index == 6 || index == 8 || index == 10 || index == 12 || index == 14) {
      previousValue = value;
    }
    else if (index == 5) {
      pm1 = 256 * previousValue + value;
      //Serial.print("{ ");
      Serial.print("PM1=");
      Serial.print(pm1);
      Serial.print(";");
      //Serial.println(" ug/m3, ");
    }
    else if (index == 7) {
      pm2_5 = 256 * previousValue + value;
      Serial.print("PM2,5=");
      Serial.print(pm2_5);
      Serial.print(";");
      //Serial.println(" ug/m3, ");
    }
    else if (index == 9) {
      pm10 = 256 * previousValue + value;
      Serial.print("PM10= ");
      Serial.print(pm10);
      Serial.print(";");
      //Serial.println(" ug/m3, ");
    } else if (index > 15) {
      break;
    }
    index++;
  }
  while(Serial.available()) Serial.read();
  Serial.print("T=");
  Serial.print(temperatura);
  Serial.print(";");
  //Serial.println(" *C, ");
  Serial.print("H=");
  Serial.print(wilgotnosc);
  Serial.print(";");
  //Serial.print(" %, ");
  Serial.println(); 
  
  delay(3000);
}
