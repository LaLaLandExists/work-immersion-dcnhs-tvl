CREATE TABLE IF NOT EXISTS Service (
  id INT NOT NULL AUTO_INCREMENT,
  
	serviceGroup TEXT NOT NULL,
	serviceName TEXT NOT NULL,
	rate DOUBLE NOT NULL,
	quantity INT NOT NULL,
	
	PRIMARY KEY (id)
);