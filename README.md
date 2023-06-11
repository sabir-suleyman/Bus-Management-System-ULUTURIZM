## Read this File in other languages:
<a href="README.md"><img src="https://img.shields.io/badge/-ENGLISH-red?style=for-the-badge"></a>
<a href="README.tr.md"><img src="https://img.shields.io/badge/-T%C3%9CRK%C3%87E-red?style=for-the-badge"></a>

# 🧩 Project Details

Bus management system with graphical interface prepared using current data structures as the final project of "BMB2006-Data Structures" subject

# 🏆 Team Members

| Name                  | GitHub Username                                     |
|-----------------------|-----------------------------------------------------|
| Sabir Süleymanlı      | [sabir-suleyman](https://github.com/sabir-suleyman) |
| Zeynep Uysal          | [zeynep-u](https://github.com/zeynep-u)             |
| Zeynep Kılınçer       | [zkilincer](https://github.com/zkilincer)           |
| İrem İçöz             | [irem0](https://github.com/irem0)                   |
| Ferit Yiğit Balaban   | [fybx](https://github.com/fybx)                     |
| Mine Korkmaz          | [minekorkmazz](https://github.com/minekorkmazz)     |
| Helin Gül             | [ihelingul](https://github.com/ihelingul)           |
| Damla Soydan          | [damlas21](https://github.com/damlas21)             |
| Fatma Büşra Tilki     | [fatmabusratilki](https://github.com/fatmabusratilki)|
| Fatma Nur Ayyıldız    | [fatmanur01](https://github.com/fatmanur01)         |


# 🚌 Title of the Project: ULU TURİZM (More than a Bus Company)
It is a software project that will be used to keep reservation and ticket records of a bus company.

# 1. INTRODUCTION 💡
## 1.1 Objective
**Easy Ticket Purchase**: Providing users with the opportunity to purchase bus tickets with ease. Ticket Sales Platform: Providing a platform for the bus company to sell tickets. 
**Improving User Experience**: To facilitate users' travel plans and improve their experience. 
**Ticket Search and Booking**: The ability to search and book tickets according to users' preferences such as travel dates, departure and arrival points, bus classes.
**Seat Selection**: The ability for users to select their preferred seat on the bus they will travel on.
**Notifications and Communication**: Push notifications and communication channels to provide users with important notifications such as booking confirmations, ticket reminders, trip cancelations.

## 1.2. Work-Timeline

![image](https://github.com/sabir-suleyman/Bus-Management-System-ULUTURIZM/blob/main/images/iszamancizelgesi.png)

## 1.3 Project Requirements: 

1- *Bus Schedule Management*:
Adding, editing and deleting bus schedules.
Saving information such as date, time, route, departure and arrival points of the trips.

2- *Passenger Information Management*:
Recording personal information of passengers such as name, surname, gender, age.
Keeping ticket information of passengers.
Performing ticket cancellation operations of passengers.

3- *Bus and Seat Management*:
Recording the information of buses and seats.
Tracking and displaying empty and occupied seats.
Marking full seats when a reservation is made.

![image](https://github.com/sabir-suleyman/Bus-Management-System-ULUTURIZM/blob/main/images/projegereksinimleri.jpg)

# 2. METHOD 📚

## 2.1. Implementation Phase 
- The necessary resources for the realization of the project were secured
- Necessary plans for the project were made
- Project progressed according to plan
- Project process was regularly monitored and progress reported
- Problems identified and solution processes managed

## 2.2. Design

Interface Design:

The interface of the application was created using WinForms (Windows Forms), a GUI technology developed by Microsoft for the .NET Framework platform and .NET 6.0 version was used in its development. The interface, which consists of 2 windows in total, allows the user to perform important operations such as entering personal information required for logging in, creating tickets to any place at any time, and deleting the tickets created. 

![image](https://github.com/sabir-suleyman/Bus-Management-System-ULUTURIZM/blob/main/images/arayuz1.png)

In another window that opens during ticket creation, there are buttons designed to allow the user to select the seat and access seat status information (empty seats - green, occupied seats - red) during the journey, allowing the user to quickly select the seat they want to sit in with a single click. 

![image](https://github.com/sabir-suleyman/Bus-Management-System-ULUTURIZM/blob/main/images/arayuz2.png)

# 3. APPLICATION 📲
**Bus Class**:
A bus class has been written. This class contains the properties and behavior of the bus and will be used to manage ticket transactions.

Expedition: A property where the bus is associated with the Trip object. The trip object contains the bus's route and other trip information.

empty_seats and occupied_seats: Tree structures representing empty seats and occupied seats. These
trees are used to track the status of seats on the bus.

TicketAl(int seatNo): A function that reserves the seat with the specified seat number. The corresponding seat is removed from the empty_seats tree and added to the occupied_seats tree.

Delete Ticket(int seatNo): A function that cancels the reservation of the seat with the specified seat number. The corresponding seat is removed from the full_seats tree and added to the empty_seats tree.

By creating bus objects, seat status can be tracked and operations such as ticket purchase or cancellation can be performed.

**Ticket Class**:
A ticket class has been written. This class contains the properties and information of a ticket.
It represents properties such as name, surname, ID number, gender, age of the owner of the ticket.
Ticket(string kisiAdSoyadi, string idNo, int biletID, bool gender, string emailAddress, Bus bus, Time sefer): This method takes the properties of the ticket as parameters and assigns values to them.

**Trip Class**:
A trip class has been written.  This class represents the start and destination points of a trip. 
It is a class that represents the start and destination of a voyage. 
Expedition(AnVeDestination departure, AnVeDestination arrival): This method takes the starting point and destination information of the expedition as parameters and assigns values to the related properties.

**Moment and Place Class**:
A moment and place class has been written. This class is used to represent a place and a time.
AnVeMekan(Venue venue, DateTime an): This method takes a Venue object and a DateTime value and assigns values to the corresponding properties.

**HashMap Class**:
A HashMap class has been written. This class represents a hash table data structure.
HashMap(int bucketCount = 16): This method takes the number of seats as a parameter and assigns it to the bucketCount field. By default the number of seats is set to 16. Also, a list array is created for the buckets field and populated with each list instance.
A custom method called HashFunction is defined.
A public method called TicketDelete is defined. This method deletes an element from the table using a specific key.

**Ticket creation**:
A global variable called counter is defined and assigned an initial value of 0. This variable acts as a counter that will be incremented one by one each time a ticket is created.
A function called CreateTicket has been defined. This function handles ticket creation and has no return value.
It assigns the selected texts from the three ComboBox components to the corresponding variables. These variables hold the ticket's from, to and departure information.
The counter value is assigned to a variable named Id and then counter is incremented by one. Thus, each time a new ticket is created, the Id variable takes a different value than the previous one.


**Bus Container Class**: 
A class named OtobusKonteyner was written in the DataStructures namespace. 
It defines a publicly accessible class called Bus Container. This class is derived from the SingleDonluDugum<Otobus> class.
AutobusContainer(Autobus bus) : base(bus): This method takes an Otobus object and passes it to the constructor method of the base class. Also, it assigns this object to the Bus property


**List of Cities/Terminals**: 
Here, the process of storing cities and terminals belonging to these cities was performed using the linked list. The linked list is a data structure that allows data to be stored and accessed in an organized manner. Using a linked list for the cities and terminals of the bus company allows the data to be stored in a hierarchical structure and accessed quickly. 
The Terminal class contains the name of a terminal and a reference to the next terminal. In this way, there can be more than one terminal for a city and each terminal can point to the next terminal.
The City class contains the name of a city, a Terminal object to store the terminals of that city, and a reference to the next city. The AddTerminal method is used to add a new terminal to a city. If the list of terminals is empty, a new terminal is created and assigned as the start of the list. Otherwise, the list of terminals is scanned until the last terminal is reached and the next reference of the last terminal is assigned as the new terminal.
The BusCompany class contains a City object to store all the cities and methods to add, find, etc. The AddCity method is used to add a new city. If the list of cities is empty, a new city is created and assigned as the start of the list. Otherwise, the list of cities is scanned until the last city is reached and the next reference of the last city is assigned as the new city.
The FindCity method is used to specify the name of a city and find that city. If a city with the specified city name exists, it is returned. Otherwise, a null value is returned.
  
**Bus List Class**:
A class named OtobusListesi was written in the DataStructures namespace. 
Defines a class called BusList. This class is derived from the SingleBoundList<BusContainer> class.
The Bas property represents the head of the list and can take an object of type BusContainer or null. 
This class is used to hold bus containers in a linked list structure.


**Ticket List Class**:
A class called TicketList was written in the DataStructures namespace.
Defines a class named TicketList. This class is derived from the SingleBoundList<TicketContainer> class.
The Bas property represents the head of the list and can take an object of type TicketContainer or null. This class is used to hold ticket containers in a linked list structure.
  
  
# 4. TESTING AND EVALUATION ⚙
Some of the project requirements were successfully fulfilled and tested. The code was assessed to be readable and understandable. Data structures and algorithms were chosen and implemented correctly. It was also tested that the functions did not return erroneous or unexpected results. The performance of the application was measured and evaluated. Tested that the user can easily use the application. It was also evaluated that the code has a convenient structure for updating and maintaining.


# 5. CONCLUSION (DISCUSSION AND CONCLUSION) 💬
Throughout the development process, we worked in line with project requirements and customer expectations. Technical details such as legibility and comprehensibility of the code, correct selection of data structures and effective use of algorithms were taken into account in the project evaluation.
A user-friendly interface design made it easy for the user to use the application. It was also evaluated that the application has a suitable structure for maintenance and updating.
During the project phase, there were difficulties in connecting the classes harmoniously with each other and integrating them with the interface. In particular, a large number of different classes were created to ensure that data structures and algorithms were chosen correctly and that data was managed and processed appropriately. 
However, making these classes compatible with each other and integrating them with the interface became a time-consuming and challenging process. To overcome these challenges, we first properly identified and designed the requirements of the project. Then, the functions and tasks of each class were identified and the necessary connections were established to make these classes compatible with each other.
