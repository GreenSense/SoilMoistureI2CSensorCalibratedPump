#ifndef SOILMOISTURESENSOR_H_
#define SOILMOISTURESENSOR_H_

extern int soilMoistureLevelCalibrated;
extern int soilMoistureLevelRaw;

extern long lastSoilMoistureI2CSensorReadingTime;
extern long soilMoistureSensorReadingIntervalInSeconds;
extern int soilMoistureSensorReadIntervalIsSetFlagAddress;

extern int drySoilMoistureCalibrationValue;
extern int wetSoilMoistureCalibrationValue;

extern bool soilMoistureSensorIsOn;
extern long lastSensorOnTime;
extern int delayAfterTurningSensorOn;
extern bool soilMoistureSensorReadingHasBeenTaken;

void setupSoilMoistureI2CSensor();

void setupCalibrationValues();

void setupSoilMoistureI2CSensorReadingInterval();

void turnSoilMoistureI2CSensorOn();

void turnSoilMoistureI2CSensorOff();

void takeSoilMoistureI2CSensorReading();

double getAverageSoilMoistureI2CSensorReading();

double calculateSoilMoistureLevel(int soilMoistureSensorReading);

void setEEPROMIsCalibratedFlag();

void setSoilMoistureI2CSensorReadingInterval(char* msg);
void setSoilMoistureI2CSensorReadingInterval(long readInterval);

long getSoilMoistureI2CSensorReadingInterval();

void setEEPROMSoilMoistureI2CSensorReadingIntervalIsSetFlag();
void removeEEPROMSoilMoistureI2CSensorReadingIntervalIsSetFlag();

void setDrySoilMoistureCalibrationValue(char* msg);

void setDrySoilMoistureCalibrationValueToCurrent();

void setDrySoilMoistureCalibrationValue(int drySoilMoistureCalibrationValue);

void setWetSoilMoistureCalibrationValue(char* msg);

void setWetSoilMoistureCalibrationValueToCurrent();

void setWetSoilMoistureCalibrationValue(int wetSoilMoistureCalibrationValue);

void reverseSoilMoistureCalibrationValues();

int getDrySoilMoistureCalibrationValue();

int getWetSoilMoistureCalibrationValue();

void setEEPROMIsCalibratedFlag();

void removeEEPROMIsCalibratedFlag();

void restoreDefaultSoilMoistureI2CSensorSettings();
void restoreDefaultSoilMoistureI2CSensorReadingIntervalSettings();
void restoreDefaultCalibrationSettings();
#endif
/* SOILMOISTURESENSOR_H_ */
