# Fitness-app

## University team project which consists of 5 people:

Ignas Baltuonė<br/>
Justas Pranauskis<br/>
Benas Dorochinas<br/>
Pijus Jonas Navasaitis<br/>
Karolis Žukauskas<br/>

## Project idea

Fitness app which lets user to count how many calories user consumed in a day.<br/>
Let user count how many calories user need to consume so that he loses, maintains or gains weigth.<br/>
more to be added...<br/>

## Tech stack

Front-end: [React.js](https://reactjs.org/)<br/>
Styling: [React-Bootstrap](https://react-bootstrap.github.io/)<br/>
Back-end: [.NET 6](https://dotnet.microsoft.com/en-us/)<br/>
Database: [SQL Server Express](https://www.microsoft.com/en-us/sql-server/)<br/>

## Building

### Windows

Requirements:
 - [Node.js](https://nodejs.org/en/download/current/) (>= 17.7.2)
 - [.NET SDK 6](https://dotnet.microsoft.com/en-us/download) (>=6.0.0)

Install:
```
git clone https://www.github.com/Justxs/Fitness-app.git
cd Fitness-app && cd ClientApp
npm install
npm start
```

### Linux

Requirements:
 - Ubuntu 20.04 LTS:
```
curl -fsSL https://deb.nodesource.com/setup_17.x | sudo -E bash -
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get install -y nodejs dotnet-sdk-6.0
```
 - Arch Linux:
```
sudo pacman -S nodejs npm dotnet-sdk
```

Install:
```
git clone https://www.github.com/Justxs/Fitness-app.git
cd Fitness-app && cd ClientApp
npm install
npm start
```
