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
| User views stylist | Click 'stylists' link | List of stylists appears  |
| User views client | Click 'clients' link  | List of clients appears |
| User enters new stylist | Stylist name, stylist, contact | "Success" |
| User enters new client | Client name, stylist, contact | "Success" |
| User updates client info | Edit this client | Routes back to Client with new info |
| User updates stylist info | Edit this stylist | Routes back to Stylist with new inf  |
| User deletes client info | Confirm deletion | "Success" |
| User deletes stylist info | Confirm deletion | "Success" |

## Setup/Installation Requirements
# Github

Go to Github repository page at https://github.com/aglines-epicodus/csharp-week2-project
Click the "download or clone" button and copy the link.
In your computer's terminal type "git clone" and paste the copied link.

#Database
Open SSMS ; select File > Open > File and select the "hairsalon.sql" file included with the Github download.  If the database "hair_salon" does not already exist, add the following lines to the top of the script file:
\> CREATE DATABASE [your_database_name]
\> GO
Save the file with the added lines.
Click Execute.


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
