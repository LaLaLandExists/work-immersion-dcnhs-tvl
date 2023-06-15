
CREATE TABLE IF NOT EXISTS Reservation (
	id INT NOT NULL AUTO_INCREMENT,
	clientId INT NOT NULL,
	roomId INT NOT NULL,
	arrival DATE NOT NULL,
	-- From spec, "nights" can be calculated in the client not in the database
	departure DATE NOT NULL,
	adultCount INT NOT NULL,
	childCount INT NOT NULL,
	issuer INT NOT NULL,
	issuedDate DATE NOT NULL,
	state TEXT NOT NULL, -- Can be 'WAITING', 'IN_HOUSE', 'CHECKED_OUT'
	
	PRIMARY KEY (id),
	FOREIGN KEY (clientId) REFERENCES Client(id),
	FOREIGN KEY (roomId) REFERENCES Room(id),
	FOREIGN KEY (issuer) REFERENCES UserInfo(id)
);
