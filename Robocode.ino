#include <Servo.h> 
 
Servo servos[6];  // maak zes servos
char command;  

 
void setup() 
{ 
  Serial.begin(9600);
  servos[0].attach(3);
  servos[1].attach(5);
  servos[2].attach(6);
  servos[3].attach(9);
  servos[4].attach(10);
  servos[5].attach(11);
} 
 
void loop() 
{ 
  if (Serial.available() > 1) {
    command = Serial.read();
    if ( 0 <= command <= 5 ) {
      servos[command].write(Serial.read()); 
    }
  }
  delay(5);
} 
