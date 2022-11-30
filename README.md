# VehiclesSystem
Postman Linkler
Get
https://localhost:7155/api/Car
-----------------------
Post
https://localhost:7155/api/Car
------------------------
{
  "color": "green",
  "headlights": true,
  "wheels": 4
}
------------------------
Put
https://localhost:7155/api/Car
-------------------------------
{
 "id":6,
  "color": "green",
  "headlights": false,
  "wheels": 4
}
-------------------------------
Delete
https://localhost:7155/api/Car/6
-------------------------------
Get (Renklere göre getirmek için)
https://localhost:7155/api/Car/color?color=blue
-------------------------------
