use master
go
use StarKidz

Insert into Donors(Name,Surname,Email,ContactNumber)
values ('Ivana','Naidoo','Ivananaidoo5@gmail.com','0713658503'),
		('Tiara','Surajbali','Kiashka28@gmail.com','0814088842'),
		('Maneasan','Pillay','MPillay@gmail.com','0712246545'),
		('Rafael','Ravele','RRavele@gmail.com','0798657732'),
		('Caylene','Naicker','CNaickerr@gmail.com','0823457654')
Insert into Payments(CardNo,CardHolder,CVV)
values('90875421','I Naidoo','678'),
		('1234567890','T Surajbali','986'),
		('MPillay','34567890654321','654'),
		('R Ravele','1234565432','986'),
		('C Naicker','657483920','245')

insert Donations(DonorID,PaymentID,Amount,Description)
values ('1','1','100000','Help the kids'),
		('1','1','90000',''),
		('4','4','9000',''),
		('3','3','1000000',''),
		('2','2','9000000','For the kids')
insert into Grades(Grade,Description)
values ('1','Primary school'),
		('2','Primary school'),
		('3','Primary school'),
		('4','Primary school'),
		('5','Primary school'),
		('6','Primary school'),
		('7','Primary school')
insert into Subjects (Title,Description,Credits)
values ('Addidtion','Adding of numbers','5')
		,('Subtraction','Minusing of numbers','6')
		,('Multipication','Timesing numbers','8')
		,('Division','Dividing numbers','10'),
		('Combination','Adding,minusing,diving and subtracting','15')

insert into MarkLevels(Level, Description,Symbol)
values('10','Fail','F'),('20','Fail','F'),('30','Fail','F'),
		('40','Fail','F'),('50','Pass','D'),('60','Pass','C'),
		('70','Pass','B'),('80','Distinction','A'),('90','Distinction','A')
insert into Questions ( SubjectID , Question,Answer,GradeID,Marks)
values ('1','10 + 1','11','1','1'),('1','10 + 2 + 3','15','3','3'),('1','13 + 14 + 67','94','7','5'),
		('2','10 - 5','5','2','1'),('2','27 - 7 - 3','17','5','3'),('2','65 - 13 - 7','45','6','5'),
		('3','5 x 10','50','3','1'),('3','4 x 8','32','2','3'),('3','4 x 9 x 6','216','7','5'),
		('4','20 / 2','10','1','1'),('4','204 / 2 / 3','52','3','5'),('4','108 /9 /3','6','7','5'),
		('5','9 x 36 / 3 - 4 + 13','117','7','10'),('5','1 x 5 + 2','7','1','4'),('5','10 + 3 x 3 -2','17','3','4')

insert into Parents(Name,Surname,Email)
values ('Reiley','Asaram','RAsaram@gmail.com'),('Zhane', 'Naidoo','ZNaidoo@gmail.com')
		,('Harry','Potter','Hp@hogwarts.com'),
		('Hermione','Granger','HG@hogwarts.com'),('Caylene','Naicker','CNaicker@gmail.com')

insert into Users(ParentID,Username,Password)
values ('1','RAsaram15','Ivana19'),('2','ZNaidoo','Zn2312'),
		('3','HPotter','Ginny'),('4','HGranger','Ron'),('5','CNaicker','Cn2206')

insert into Learners(Name,Surname,Email,GradeID,UserID)
values ('Rob','Asaram','','3','1'),('Luka','Asaram','LAsaram@gmail.com','7','1'),
		('Zara','Naidoo','ZaraNaidoo@gmail.com','7','2'),
		('Albus','Potter','','5','3'),('James','Potter','Jpotter@hogwarts.com','7','3'),('Lilly','Potter','','6','3'),
		('Rose','Weasley','','5','4'),('Hugo','Weasley','HWeasley@Hogwarts.com','4','4'),
		('Mac','Naicker','','2','5'),('Winter','Naicker','','1','5'),('Meiko','Naicker','','1','5')