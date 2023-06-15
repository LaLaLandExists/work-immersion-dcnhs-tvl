
--string -> TEXT NOT NULL, string? -> TEXT
--PK: id int -> id INT NOT NULL AUTO_INCREMENT, ... PRIMARY KEY (id)

CREATE TABLE IF NOT EXISTS Reservation (
	id INT NOT NULL AUTO_INCREMENT,
	clientType TEXT NOT NULL, -- FIXME?: Create a client type table
	roomId INT NOT NULL,
	arrival DATE NOT NULL,
	-- From spec, "nights" can be calculated in the client not in the database
	departure DATE NOT NULL,
	checkOutTime TIME NOT NULL,
	adultCount INT NOT NULL,
	childCount INT NOT NULL,
	issuer INT NOT NULL,
	issuedDate DATE NOT NULL,
	inHouse BOOLEAN NOT NULL,
	
	PRIMARY KEY (id),
	FOREIGN KEY (roomId) REFERENCES Room(id),
	FOREIGN KEY (issuer) REFERENCES UserInfo(id)
);
