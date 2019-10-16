use StarKidz
go
create table Parents(
ParentID int primary key,
Name VARCHAR(100) Not null,
Surname VARCHAR(40),
Email VARCHAR(100))
go
create table Users(
UserID int primary key Not null,
ParentID int Not null,
Username VARCHAR(40) Not null,
Password VARCHAR(80) Not null
constraint FK_Users_Parents Foreign key (ParentID) references Parents(ParentID))
go 
create table Subjects(
SubjectID int primary key Not null,
Title VARCHAR(40) Not null,
Description VARCHAR(200),
Credits int)
go
create table Grades(
GradeID int primary key Not null,
Grade int not null, 
Description  VARCHAR(200))
go
create table MarkLevels(
MarkID int primary key Not null,
Level  int not null	,
Description VARCHAR(200))
go
create table Donors(
DonorID  int primary key Not null,
Name VARCHAR(100),
Surname VARCHAR(40),
Email VARCHAR(100),
ContactNumber VARCHAR(10))
go
create table Payments(
PaymentID int primary key Not null,
CardNo VARCHAR(20) not null,
CardHolder VARCHAR(20) ,
CVV VARCHAR(3),
)
go
create table Donations(
DonationID int primary key Not null,
DonorID int,
PaymentID int,
Amount FLOAT ,
Description VARCHAR(200)
constraint FK_Donations Foreign key (DonorID) references Donors(DonorID),
			 Foreign key (PaymentID) references Payments(PaymentID))
go
create table Learners(
LearnerID int primary key Not null,
Name VARCHAR(200),
Surname VARCHAR(200),
Email VARCHAR(200),
GradeID int not null,
UserID int not null
constraint FK_Learners foreign key  (GradeID) references Grades(GradeID),foreign key (UserID) references Users(UserID))		
go 
create table Questions(
QuestionID int primary key Not null,
SubjectID int not null,
Question VARCHAR(200),
Answer int,
GradeID int,
Marks int
constraint FK_Question foreign key  (GradeID) references Grades(GradeID),foreign key (SubjectID) references Subjects(SubjectID))
go
create table Homeworks(
HomeworkID int primary key Not null,
LearnerID int not null,
HomeworkDate date not null,
Description VARCHAR(200)
constraint FK_HWs foreign key  (LearnerID) references Learners(LearnerID))
go
create table HomeworkQuestions(
HomeworkID int,
QuestionID int,
Mark int,
constraint FK_Question foreign key  (HomeworkID) references Homeworks(HomeworkID),foreign key (QuestionID) references Questions(QuestionID))
go
create table Tests(
TestID int primary key Not null, 
LearnerID int not null,
Description VARCHAR(200),
Mark int,
TestDate date,
constraint FK_Question foreign key  (LearnerID) references Learners(LearnerID))
go
create table TestQuestions(
TestID int,
QuestionID int,
Mark int,
constraint FK_Question foreign key  (TestID) references Tests(TestID),foreign key (QuestionID) references Questions(QuestionID))
go
create table Reports(
LearnerID int,
SubjectID int,
UserID int
MarkLevelID int
ReportDate date,
constraint FK_Question foreign key  (LearnerID) references Learners(LearnerID),foreign key (SubjectID) references Subjects(SubjectID),
 foreign key  (UserID) references Users(UserID),foreign key (MarkLevelID) references MarkLevela(MarkLevelID),
go