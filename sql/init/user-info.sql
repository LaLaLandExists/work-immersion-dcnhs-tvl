
CREATE TABLE IF NOT EXISTS UserInfo (
	id INT NOT NULL AUTO_INCREMENT,
	userType TEXT NOT NULL, -- "USER" or "ADMIN"
	firstName TEXT NOT NULL,
	lastName TEXT NOT NULL,
	userName TEXT NOT NULL,
	password TEXT NOT NULL,
	
	PRIMARY KEY (id)
);
