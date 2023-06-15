
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
	
	amount INT,
		
	vehicleBrand TEXT,
	vehicleModel TEXT,
	vehicleColor TEXT,
	license TEXT,
	
	PRIMARY KEY (id)
);
