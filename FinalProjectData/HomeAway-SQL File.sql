




create database HomeAway;
use HomeAway



create table User(UserId int auto_increment primary key,UserName varchar(40) not null,UserContactNo varchar(10) not null,UserEmail varchar(30) not null,UserPassword varchar(20),RoleId int(1) not null);


insert into User values(1,"ChaitaliKumbhar","8562853245","chaitali@gmail.com","chaitali123",1);

insert into User values(2,"JagrutiSarode","7752986345","Jagruti@gmail.com","jagruti123",1);

insert into User values(3,"AmrutaChavan","7252608597","Amruta@gmail.com","amruta123",1);

insert into User values(4,"SwatiPathare","9209208557","swati@gmail.com","swati123",1);

insert into User values(5,"sachinjadhav","9852608597","sachin@gmail.com","sachin",2);

insert into User values(6,"komalshinde","9852608597","komal@gmail.com","komal",2);

insert into User values(7,"nikitakadam","7552608597","nikita@gmail.com","nikita",2);

insert into User values(8,"manishajoshi","8589608597","manisha@gmail.com","manisha",2);

insert into User values(9,"rakeshkumar","8562253245","rakesh@gmail.com","null",3);

insert into User values(10,"pritampatil","9562258675","pritam@gmail.com","null",3);

insert into User values(11,"jyotividhate","8262254635","jyoti@gmail.com","null",3);

insert into User values(12,"ManishKumar","7685251635","manish@gmail.com","null",3);

insert into User values(13,"pujajagtap","8975461698","puja@gmail.com","null",3);

insert into User values(14,"SonamShinde","9675461659","sonam@gmail.com","null",3);

insert into User values(15,"MayuriMore","8875485669","mayuri@gmail.com","null",3);

insert into User values(16,"revakulkarni","9575485546","reva@gmail.com","null",3);

insert into User values(17,"RaviVarma","8654972528","ravi@gmail.com","null",3);

insert into User values(18,"PritiSharma","8754978468","priti@gmail.com","null",3);

insert into User values(19,"MeghaYadav","9854978468","megha@gmail.com","null",3);

insert into User values(20,"AjayShinde","9854978468","ajay@gmail.com","null",3);

select * from user;
+--------+-----------------+---------------+--------------------+--------------+--------+
| UserId | UserName        | UserContactNo | UserEmail          | UserPassword | RoleId |
+--------+-----------------+---------------+--------------------+--------------+--------+
|      1 | ChaitaliKumbhar | 8562853245    | chaitali@gmail.com | chaitali123  |      1 |
|      2 | JagrutiSarode   | 7752986345    | Jagruti@gmail.com  | jagruti123   |      1 |
|      3 | AmrutaChavan    | 7252608597    | Amruta@gmail.com   | amruta123    |      1 |
|      4 | SwatiPathare    | 9209208557    | swati@gmail.com    | swati123     |      1 |
|      5 | sachinjadhav    | 9852608597    | sachin@gmail.com   | sachin       |      2 |
|      6 | komalshinde     | 9852608597    | komal@gmail.com    | komal        |      2 |
|      7 | nikitakadam     | 7552608597    | nikita@gmail.com   | nikita       |      2 |
|      8 | manishajoshi    | 8589608597    | manisha@gmail.com  | manisha      |      2 |
|      9 | rakeshkumar     | 8562253245    | rakesh@gmail.com   | null         |      3 |
|     10 | pritampatil     | 9562258675    | pritam@gmail.com   | null         |      3 |
|     11 | jyotividhate    | 8262254635    | jyoti@gmail.com    | null         |      3 |
|     12 | ManishKumar     | 7685251635    | manish@gmail.com   | null         |      3 |
|     13 | pujajagtap      | 8975461698    | puja@gmail.com     | null         |      3 |
|     14 | SonamShinde     | 9675461659    | sonam@gmail.com    | null         |      3 |
|     15 | MayuriMore      | 8875485669    | mayuri@gmail.com   | null         |      3 |
|     16 | revakulkarni    | 9575485546    | reva@gmail.com     | null         |      3 |
|     17 | RaviVarma       | 8654972528    | ravi@gmail.com     | null         |      3 |
|     18 | PritiSharma     | 8754978468    | priti@gmail.com    | null         |      3 |
|     19 | MeghaYadav      | 9854978468    | megha@gmail.com    | null         |      3 |
|     20 | AjayShinde      | 9854978468    | ajay@gmail.com     | null         |      3 |
+--------+-----------------+---------------+--------------------+--------------+--------+
20 rows in set (0.00 sec)



create table RoomDetails(OwnerId int,RoomId int primary key auto_increment, PropertyName varchar(50) not null, FloorNo int, Status varchar(20), Rent double not null, Deposit double, Facility varchar(200) not null, RoomAddress varchar(150) not null, Gender varchar(20) not null,RoomType varchar(50),URL1 varchar(50), URL2 varchar(50), URL3 varchar(50),
Foreign key(OwnerId) references User(UserId));

insert into roomdetails values(9,1,"GoodwillBrezza",5,"available",10000,25000,"Wifi,RO Water,Parking","Katraj","Female","DoubleSharing","/images/bed1.jpg","images/build1.jpg","/images/furn1.jpg");


insert into roomdetails values(10,2,"ShubhNirvana",2,"available",15000,30000,"Wifi,HotWater,Kitchen","sangvi","Male","ThreeSharing","/images/bed2.jpg","images/build2.jpg","/images/furn2.jpg");


insert into roomdetails values(11,3,"NyatiElan",1,"available",7000,15000,"Wifi,Gallary,Kitchen","sangvi","Female","DoubleSharing","/images/bed3.jpg","images/build3.jpg","/images/furn3.jpg");


insert into roomdetails values(12,4,"Megapolis",2,"available",5000,10000,"Wifi,HouseKeeping,Kitchen","VimanNgar","Other","Single","/images/bed4.jpg","images/build4.jpg","/images/furn4.jpg");

 insert into roomdetails values(13,5,"Megapolis",4,"available",16000,22000,"RoWater,Gallary,Kitchen","ShivajiNagar","Female","Doublesharing","/images/bed5.jpg","images/build5.jpg","/images/furn5.jpg");


insert into roomdetails values(14,6,"Engracia",11,"available",25000,35000,"Wifi,RO Water,Gallary","sangvi","Male","FourSharing","/images/bed6.jpg","images/build6.jpg","/images/furn6.jpg");


 insert into roomdetails values(15,7,"Yashvin",6,"available",4000,12000,"Wifi,Gallary,Kitchen","Baner","Female","Single","/images/bed7.jpg","images/build7.jpg","/images/furn7.jpg");


 insert into roomdetails values(16,8,"Kohinoor",9,"available",22000,30000,"Wifi,ROWater,HotWater","Baner","Male","FourSharing","/images/bed8.jpg","images/build8.jpg","/images/furn8.jpg");


 insert into roomdetails values(17,9,"Katepuram",3,"available",1600,21000,"Wifi,Kitchen,ROWater","ShivajiNagar","Female","DoubleSharing","/images/bed9.jpg","images/build9.jpg","/images/furn9.jpg");


 insert into roomdetails values(18,10,"Pride",1,"available",2300,25000,"Wifi,Gallary,Kitchen","Katraj","Male","Single","/images/bed10.jpg","images/build10.jpg","/images/furn10.jpg");


 insert into roomdetails values(19,11,"GangaTown",8,"available",16000,24000,"Wifi,Parking,Kitchen","Katraj","Other","DoubleSharing","/images/bed11.jpg","images/build11.jpg","/images/furn11.jpg");


insert into roomdetails values(20,12,"Kundan",14,"available",26000,36000,"Gallary,Kitchen,parking","VimanNagar","Male","FourSharing","/images/bed12.jpg","images/build12.jpg","/images/furn12.jpg");


 
select * from roomdetails;
+---------+--------+----------------+---------+-----------+-------+----------+----------------------------------------+--------------+--------+----------+-------------------+--------------------+--------------------+
| OwnerId | RoomId | PropertyName   | FloorNo | Status    | Rent  | Deposite | Facility                  | RoomAddress  | Gender | RoomType      | URL1              | URL2               | URL3               |
+---------+--------+----------------+---------+-----------+-------+----------+----------------------------------------+--------------+--------+----------+-------------------+--------------------+--------------------+
|    9    |      1 | GoodwillBrezza |       5 | available | 10000 |    25000 | Wifi,RO Water,Parking     | Katraj       | Female | DoubleSharing | /images/bed1.jpg  | images/build1.jpg  | /images/furn1.jpg  |
|    10   |      2 | ShubhNirvana   |       2 | available | 15000 |    30000 | Wifi,HotWater,Kitchen     | sangvi       | Male   | ThreeSharing  | /images/bed2.jpg  | images/build2.jpg  | /images/furn2.jpg  |
|    11   |      3 | NyatiElan      |       1 | available |  7000 |    15000 | Wifi,Gallary,Kitchen      | sangvi       | Female | DoubleSharing | /images/bed3.jpg  | images/build3.jpg  | /images/furn3.jpg  |
|    12   |      4 | Megapolis      |       2 | available |  5000 |    10000 | Wifi,HouseKeeping,Kitchen | VimanNgar    | Other  | Single        | /images/bed4.jpg  | images/build4.jpg  | /images/furn4.jpg  |
|    13   |      5 | Megapolis      |       4 | available | 16000 |    22000 | RoWater,Gallary,Kitchen   | ShivajiNagar | Female | DoubleSharing | /images/bed5.jpg  | images/build5.jpg  | /images/furn5.jpg  |
|    14   |      6 | Engracia       |      11 | available | 25000 |    35000 | Wifi,RO Water,Gallary     | sangvi       | Male   | FourSharing   | /images/bed6.jpg  | images/build6.jpg  | /images/furn6.jpg  |
|    15   |      7 | Yashvin        |       6 | available |  4000 |    12000 | Wifi,Gallary,Kitchen      | Baner        | Female | Single        | /images/bed7.jpg  | images/build7.jpg  | /images/furn7.jpg  |
|    16   |      8 | Kohinoor       |       9 | available | 22000 |    30000 | Wifi,ROWater,HotWater     | Baner        | Male   | FourSharing   | /images/bed8.jpg  | images/build8.jpg  | /images/furn8.jpg  |
|    17   |      9 | Katepuram      |       3 | available |  1600 |    21000 | Wifi,Kitchen,ROWater      | ShivajiNagar | Female | DoubleSharing | /images/bed9.jpg  | images/build9.jpg  | /images/furn9.jpg  |
|    18   |     10 | Pride          |       1 | available |  2300 |    25000 | Wifi,Gallary,Kitchen      | Katraj       | Male   | Single        | /images/bed10.jpg | images/build10.jpg | /images/furn10.jpg |
|    19   |     11 | GangaTown      |       8 | available | 16000 |    24000 | Wifi,Parking,Kitchen      | Katraj       | Other  | DoubleSharing | /images/bed11.jpg | images/build11.jpg | /images/furn11.jpg |
|    20   |     12 | Kundan         |      14 | available | 26000 |    36000 | Gallary,Kitchen,Parking   | VimanNagar   | Male   | FourSharing   | /images/bed12.jpg | images/build12.jpg | /images/furn12.jpg |
+---------+--------+----------------+---------+-----------+-------+----------+----------------------------------------+--------------+--------+----------+-------------------+--------------------+--------------------+
12 rows in set (0.00 sec)

create table Booking(CustomerId int primary Key, roomId int not null,BookingAmount double, Date varchar(20));



