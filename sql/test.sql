
-- Test database to debug the validation layer

CREATE TABLE Student (
	id INT NOT NULL AUTO_INCREMENT,
	firstName TEXT NOT NULL,
	middleName TEXT,
	lastName TEXT NOT NULL,
	
	PRIMARY KEY (id)
);

CREATE TABLE AllNew (
	id INT NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Elective (
	id INT NOT NULL AUTO_INCREMENT,
	name TEXT NOT NULL,
	units INT NOT NULL,
	
	PRIMARY KEY (id)
);

CREATE TABLE StudentElective (
	studentId INT NOT NULL,
	electiveId INT NOT NULL,
	
	FOREIGN KEY (studentId) REFERENCES Student(id),
	FOREIGN KEY (electiveId) REFERENCES Elective(id)
);

