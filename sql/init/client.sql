--Payment Method
CREATE TABLE IF NOT EXISTS PaymentMethod (
	paymentID INT NOT NULL AUTO_INCREMENT,
	walkInID INT NOT NULL,
	
	PRIMARY KEY (PaymentID),
	FOREGIN KEY (WalkInID) REFERENCES Reservation(id)
);

CREATE TABLE IF NOT EXISTS Card (
	id INT NOT NULL,
	cardType TEXT,
	cardNum TEXT NOT NULL,
	auth TEXT NOT NULL,
	expDate DATE NOT NULL,
	cardHolder TEXT NOT NULL,
	
	FOREIGN KEY (id) REFERENCES PaymentMethod(PaymentID)
);

CREATE TABLE IF NOT EXISTS Cash (
	id INT NOT NULL,
	amount INT NOT NULL,
	
	FOREIGN KEY (id) REFERENCES PaymentMethod(PaymentID)
);

CREATE TABLE IF NOT EXISTS GCash (
	id INT NOT NULL,
	
	GCashNum = TEXT,
	name TEXT,
	QR TEXT,
	Amount INT NOT NULL,
	
	FOREIGN KEY (id) REFERENCES PaymentMethod(PaymentID)
);

-- Client
CREATE TABLE IF NOT EXISTS Client (
	id INT NOT NULL AUTO_INCREMENT,
	
	nameTitle TEXT,
	firstName TEXT NOT NULL,
	middleName TEXT,
	lastName TEXT NOT NULL,
	
	streetAd TEXT,
	zipCode TEXT NOT NULL,
	cityAd TEXT,
	countryAd TEXT,
	stateProvinceAd TEXT,
	nationality TEXT,

	guestNote TEXT,
	
	telephone TEXT,
	mobile TEXT NOT NULL,
	email TEXT,
	
	postDepo BOOLEAN,
	amount INT,
	
	paymentID INT NOT NULL,
	
	vehicleBrand TEXT,
	vehicleModel TEXT,
	vehicleColor TEXT,
	license TEXT,
	
	PRIMARY KEY (id),
	FOREIGN KEY (PaymentID) REFERENCES PaymentMethod(PaymentID)
); 
