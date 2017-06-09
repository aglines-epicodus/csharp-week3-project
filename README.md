# Hair Salon

#### Weekly project for C Sharp

#### **By Andrew Glines for Epicodus**

## Description

This application will allow a user to operate a database of stylists and clients for a hair salon.
A user will be able to select a stylist and see their details, including a list of all that stylist's clients.
A user will be able to add new stylists, add new clients to any stylist, update a client's data, or delete a client.  

## Behavior and Inputs

|  behavior | input  | output  |
|---|---|---|
| User enters new stylist |  |  |
| User enters new client |  |  |
| User views stylist |  |  |
| User views client |  |  |
| User updates client info |  |  |
| User deletes client info |  |  |
| User updates stylist info |  |  |
| User deletes stylist info |  |  |


## Setup/Installation Requirements

Go to Github repository page at https://github.com/aglines-epicodus/csharp-week2-project
Click the "download or clone" button and copy the link.
In your computer's terminal type "git clone" and paste the copied link.

Set up the database in SQLCMD using the following statements:
\> CREATE DATABASE todo; > GO
\> USE hair_salon; > GO
\> CREATE TABLE stylists (id INT IDENTITY(1,1), name VARCHAR(255), contact VARCHAR(255), photo_link VARCHAR(255));
\> CREATE TABLE clients (id INT IDENTITY(1,1), name VARCHAR(255), stylist_id INT, contact VARCHAR(255)) VARCHAR(255), contact VARCHAR(255)); > GO

Once downloaded you can open the root html file in the browser of your choice.
You can view the code using the text editor of your choice as well.

## Known Bugs

* No known bugs

## Support and contact details

If you have any issues or have questions, ideas, concerns, or contributions please contact any of the contributors through Github.

## Technologies Used

* HTML
* CSS
* Bootstrap
* JSON
* Nancy
* Razor
* xUnit
* C#
* SQL

### License
This software is licensed under the MIT license.

Copyright (c) 2017 Andrew Glines, Epicodus
