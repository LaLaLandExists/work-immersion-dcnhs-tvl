
CREATE TABLE IF NOT EXISTS UserInfo (
	id INT NOT NULL,
	userType TEXT NOT NULL, -- "USER" or "ADMIN"
	FirstName TEXT NOT NULL,
	LastName TEXT NOT NULL,
	userName TEXT NOT NULL,
	password TEXT NOT NULL,
	
	PRIMARY KEY (id)
);
