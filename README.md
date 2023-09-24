# Sensor Simulator for Smart Sensify Environment Monitoring App

## Introduction

The SmartSensify Sensor Simulator is a desktop application developed for simulating sensor data to support testing and development of the SmartSensify app. SmartSensify is a sensor data management and analytics platform designed to gather, analyze, and visualize sensor data from various sources.
The SmartSensify Sensor Simulator is designed for developers and testers working on the SmartSensify app. It enables them to create realistic test scenarios and evaluate the app's functionality with simulated sensor data.

> Curent version of app: **0.1.0**

### Features

- Simulate Sensor Data: The application allows users to create and simulate sensor data streams, including various sensor types and data generation speeds.
- User-Friendly Interface: The user interface provides an intuitive way to manage sensors and generate simulated data.
- Data Export: Simulated sensor data can be exported to files for testing and analysis.

## ChangeLog

#### 0.1.0 "Base" (Current Version)

- Initial app version with basic support of simulating sensors

## Known issues and bugs

### Major:
- Checking if sensor id and secret is valid
- Message if data is not saved into database
- Checking if sensor with the same id already exist
- Add possibility to delete sensor and sensor type
- Add possibility to edit sensor and sensor type
- Sensor type value min, max validation
- Validation when creating sensors: min-max name length, checking if sensor id and secret key is valid
- Validation on every numeric input
- User should take minimum one sensor type when creating sensor
- User should take minimum one sensor and check API connection before data generation

### Minor:
- Auto refresh after adding sensor
- secret key should be cenzored with button to uncenzor it

### API:
- Check if is connection to the sensor
- Check if data sended to the sensor is viable

_This is an early release of this app for smart sensify environment monitoring system project for my studies, focusing on creating an Environment Monitoring System. Please note that this is an early version, and some features are still under development. Use it with caution and expect updates and improvements in the future. For more information, refer to the documentation or contact me at [jakub.robert.krok@gmail.com](mailto:jakub.robert.krok@gmail.com)._

