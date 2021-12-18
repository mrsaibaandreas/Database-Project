using System;


namespace SangriaHealthCenter
{
    class Queries
    {
        public String DropTables()
        {
            String dropTables =
                @"DROP TABLE `Volunteers`, `Patients`, `MedicalStaff`, `Laboratory`, 
                `Inventory`, `Hospital`, `Donors`, `BloodBank`, `BloodBag`;";

            return dropTables;
        }

        public String InitTablesQueries()
        {
            const String CreateTableVolunteers =
    @"CREATE TABLE IF NOT EXISTS Volunteers( 
                v_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY, 
                role VARCHAR(3) CHECK(role IN('FB','IG','FLY','ADS')), 
                phone VARCHAR(10) NOT NULL, 
                name VARCHAR(20) NOT NULL, 
                surname VARCHAR(20) NOT NULL, 
                bloodbank INT(6) UNSIGNED NOT NULL);";

            const String CreateTableDonors =
                @"CREATE TABLE IF NOT EXISTS Donors( 
                d_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY, 
                regular BOOLEAN NOT NULL DEFAULT FALSE, 
                phone VARCHAR(10) NOT NULL, 
                b_group VARCHAR(3) NOT NULL CHECK(b_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')), 
                email VARCHAR(30) NOT NULL, 
                name VARCHAR(20) NOT NULL,
                surname VARCHAR(20) NOT NULL, 
                sex VARCHAR(1) NOT NULL CHECK(sex IN('m', 'f')),
                bloodbank INT(6) UNSIGNED );";

            const String CreateTablePatients =
              @"CREATE TABLE IF NOT EXISTS Patients( 
                p_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
                b_group VARCHAR(3) NOT NULL CHECK(b_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')),
                emergency BOOLEAN NOT NULL DEFAULT FALSE,
                name VARCHAR(20) NOT NULL,
                surname VARCHAR(20) NOT NULL,
                phone VARCHAR(10) NOT NULL,
                hospital INT(6) UNSIGNED NOT NULL);";

            const String CreateTableBloodBank =
                @"CREATE TABLE IF NOT EXISTS BloodBank( 
                b_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY, 
                address VARCHAR(50), 
                expenses FLOAT(6,2) NOT NULL);";

            const String CreateTableHospital =
                @"CREATE TABLE IF NOT EXISTS Hospital(	
                h_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
                name VARCHAR(30),    
                address VARCHAR(50),    
                inventory INT(6) UNSIGNED );";

            const String CreateTableInventory =
                @"CREATE TABLE IF NOT EXISTS Inventory(	
                i_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    			needles	INT(6) UNSIGNED DEFAULT 0,
				vacutainers	INT(6) UNSIGNED DEFAULT 0, 
				gloves INT(6) UNSIGNED DEFAULT 0,
				bloodbags INT(6) UNSIGNED DEFAULT 0,
				tourniquet INT(6) UNSIGNED DEFAULT 0,
				seringe	INT(6) UNSIGNED DEFAULT 0,
				lancet INT(6) UNSIGNED DEFAULT 0,
				spoges INT(6) UNSIGNED DEFAULT 0,
				glucometers	INT(6) UNSIGNED DEFAULT 0,
				sharps_container INT(6) UNSIGNED DEFAULT 0);";

            const String CreateTableMedicalStaff =
                @"CREATE TABLE IF NOT EXISTS MedicalStaff(	
                m_id INT(6) UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT,
                role VARCHAR(1) NOT NULL CHECK(role IN('d','n')),
                expenses FLOAT(6,2) NOT NULL,
                hospital INT(6) UNSIGNED,
                laboratory INT(6) UNSIGNED);";

            const String CreateTableBloodBag =
                @"CREATE TABLE IF NOT EXISTS BloodBag( 
                bb_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY, 
                b_group VARCHAR(3) NOT NULL CHECK(b_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')), 
                content VARCHAR(1) NOT NULL CHECK(content IN('b', 't', 'p')), 
                donor INT(6) UNSIGNED NOT NULL, 
                bloodbank INT(6) UNSIGNED NOT NULL);";

            const String CreateTableLaboratory =
                @"CREATE TABLE IF NOT EXISTS Laboratory(
	            l_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY ,
	            address VARCHAR(50) NOT NULL,
                bloodbank INT(6) UNSIGNED, 
                inventory INT(6) UNSIGNED,
                hospital INT(6) UNSIGNED);";

            String initQueries = CreateTableVolunteers +
                                 CreateTableDonors +
                                 CreateTablePatients +
                                 CreateTableBloodBank +
                                 CreateTableHospital +
                                 CreateTableInventory +
                                 CreateTableMedicalStaff +
                                 CreateTableBloodBag +
                                 CreateTableLaboratory;

            return initQueries;
        }

        public String InitFKs()
        {
            const String FkPatientInHospital =
            @"ALTER TABLE Patients
                ADD CONSTRAINT fk_patient_in_hospital
                FOREIGN KEY (hospital) 
                REFERENCES Hospital(h_id) 
                ON DELETE RESTRICT;";

            const String FkVolunteerInBloodbank =
                @"ALTER TABLE Volunteers
                ADD CONSTRAINT fk_volunteer_at_bloodbank
                FOREIGN KEY (bloodbank) 
                REFERENCES BloodBank(b_id) 
                ON DELETE RESTRICT;";

            const String FkDonorAtBloodbank =
                @"ALTER TABLE Donors
                ADD CONSTRAINT fk_donor_at_bloodbank
                FOREIGN KEY (bloodbank) 
                REFERENCES BloodBank(b_id) 
                ON DELETE CASCADE;";

            const String FkLaboratoryOfBloodbank =
                @"ALTER TABLE Laboratory
                ADD CONSTRAINT fk_laboratory_in_bloodbank
                FOREIGN KEY (bloodbank) 
                REFERENCES BloodBank(b_id) 
                ON DELETE SET NULL;";

            const String FkLaboratoryOfHospital =
                @"ALTER TABLE Laboratory
                ADD CONSTRAINT fk_laboratory_in_hospital
                FOREIGN KEY (hospital) 
                REFERENCES BloodBank(b_id) 
                ON DELETE SET NULL;";

            const String FkBloodbagOfDonor =
                @"ALTER TABLE BloodBag
                ADD CONSTRAINT fk_bloodbag_of_donor
                FOREIGN KEY (donor) 
                REFERENCES Donors(d_id) 
                ON DELETE CASCADE;";

            const String FkBloodbagInBloodbank =
                @"ALTER TABLE BloodBag
                ADD CONSTRAINT fk_bloodbag_in_bloodbank
                FOREIGN KEY (bloodbank) 
                REFERENCES BloodBank(b_id) 
                ON DELETE RESTRICT;";

            const String FkMedicalstaffOfHospital =
                @"ALTER TABLE MedicalStaff
                ADD CONSTRAINT fk_medicalstaff_of_hospital
                FOREIGN KEY (hospital) 
                REFERENCES Hospital(h_id) 
                ON DELETE RESTRICT;";

            const String FkMedicalstaffOfLaboratory =
                @"ALTER TABLE MedicalStaff
                ADD CONSTRAINT fk_medicalstaff_of_laboratory
                FOREIGN KEY (laboratory) 
                REFERENCES Laboratory(l_id) 
                ON DELETE RESTRICT;";

            const String FkInventoryOfLaboratory =
                @"ALTER TABLE Laboratory
                ADD CONSTRAINT fk_inventory_of_laboratory
                FOREIGN KEY (inventory) 
                REFERENCES Inventory(i_id) 
                ON DELETE CASCADE;";

            const String FkInventoryOfHospital =
                @"ALTER TABLE Hospital
                ADD CONSTRAINT fk_inventory_of_hospital
                FOREIGN KEY (inventory) 
                REFERENCES Inventory(i_id) 
                ON DELETE CASCADE;";

            String initFks = FkVolunteerInBloodbank +
                             FkPatientInHospital +
                             FkDonorAtBloodbank +
                             FkLaboratoryOfBloodbank +
                             FkLaboratoryOfHospital +
                             FkBloodbagOfDonor +
                             FkBloodbagInBloodbank +
                             FkMedicalstaffOfHospital +
                             FkMedicalstaffOfLaboratory +
                             FkInventoryOfLaboratory +
                             FkInventoryOfHospital;

            return initFks;
        }

        public String populateTables()
        {
            const String PopulateBloodBank =
                @"INSERT INTO `BloodBank` (`b_id`, `address`, `expenses`)
                    VALUES
                    ('1', 'Timisoara str. Amurgului nr. 9', '-1600.97'),
                    ('2', 'Timisoara str. Malului nr. 453', '.0'),
                    ('3', 'Arad str. Ion Creanga nr. 571', '-257.86'),
                    ('4', 'Arad str. Horia nr. 279', '233.13'),
                    ('5', 'Resita str. Closca nr. 123', '576.53'),
                    ('6', 'Resita str. Crisan nr. 29', '-247.66'),
                    ('7', 'Hunedoara str. Cetatii nr. 92', '-160.81'),
                    ('8', 'Deva str. Lampii nr. 293', '-620.31'),
                    ('9', 'Caracal Str. Andreas nr.3', '-420.11'),
                    ('10', 'Oradea str. Copac nr. 443', '-1600.23');";

            const String PopulateDonors =
                @"INSERT INTO `Donors` (`d_id`, `regular`, `phone`, `b_group`, `email`, `name`, `surname`, `sex` ,`bloodbank`) 
                    VALUES 
                    ('1', '0', '0740111111', 'A-', 'firstemail@mail.com', 'Marian', 'Popescu', 'm' , '1'),
                    ('2', '1', '0740222222', 'AB-', 'secondemail@mail.com', 'Sorina', 'Spataru', 'f' , '2'),
                    ('3', '1', '0740333333', '0-', 'thirdemail@mail.com', 'Florica', 'Mester', 'f' , '2'),
                    ('4', '1', '0740444444', 'B-', 'forthemail@mail.com', 'Andrei', 'Apetrei', 'm' , '3'),
                    ('5', '0', '0740555555', 'B+', 'fifthemail@mail.com', 'Ion', 'Ionescu', 'm' , '4'),
                    ('6', '1', '0740666666', 'B-', 'sixthemail@mail.com', 'Valentin', 'Tent', 'm' , '1'),
                    ('7', '1', '0740777777', '0+', 'seventhemail@mail.com', 'Matei', 'Rotaru', 'm' , '2'),
                    ('8', '0', '0740888888', '0+', 'eighthmail@mail.com', 'Iulian', 'Graur', 'm' , '7'),
                    ('9', '0', '0740999999', 'AB-', 'ninthemail@mail.com', 'Daniela', 'Ratiu', 'f' , '5'),
                    ('10', '1', '0740101010', 'A+', 'tenthemail@mail.com', 'Paul', 'Costache', 'm' , '4');";

            const String PopulateBloodBag =
                @"INSERT INTO `BloodBag` (`bb_id`, `b_group`, `content`, `donor`, `bloodbank`) 
                    VALUES
                    ('1', 'A-', 'b', '10', '1'),
                    ('2', 'AB-', 't', '10', '2'),
                    ('3', 'AB-', 'b', '10', '2'),
                    ('4', 'B-', 'p', '10', '3'),
                    ('5', 'B+', 'p', '10', '4'),
                    ('6', 'B+', 'p', '10', '4'),
                    ('7', '0-', 'b', '10', '2'),
                    ('8', '0+', 'b', '10', '2'),
                    ('9', '0+', 'b', '10', '2'),
                    ('10', '0+', 't', '10', '7'),
                    ('11', 'A+', 'b', '10', '4'),
                    ('12', 'A+', 'b', '10', '4');";

            const String PopulateVolunteers =
                @"INSERT INTO `Volunteers` (`v_id`, `role`, `phone`, `name`, `surname`, `bloodbank`) 
                    VALUES 
                    ('1', 'FB', '0740055123', 'Milan', 'Carin', '1'),
                    ('2', 'IG', '0741123402', 'Aurelia', 'Costache', '1'),
                    ('3', 'FB', '0740266453', 'Ana', 'Lup', '3'),
                    ('4', 'IG', '0741000212', 'Maria', 'Gheorghe', '2'),
                    ('5', 'FLY', '0740099902', 'Ionut', 'Curea', '2'),
                    ('6', 'FLY', '0740233210', 'Eduard', 'Sumudica', '4'),
                    ('7', 'FB', '0741662321', 'Edina', 'Manole', '5'),
                    ('8', 'FB', '0741131326', 'Petre', 'Armin', '7'),
                    ('9', 'FLY', '0744231230', 'Aladin', 'Jidvei', '1'),
                    ('10', 'ADS', '0740991931', 'Georgiana', 'Valea', '1');";

            const String PopulatePacients =
                @"INSERT INTO `Patients` (`p_id`, `hospital`, `b_group`, `phone`, `name`, `surname`, `emergency`)
                    VALUES 
                    ('1', '1', 'a-', '0123456789', 'Sumunica1', 'Tudor', '0'),
                    ('2', '1', 'ab-', '0123456788', 'Sumunica2', 'Alexandru', '0'),
                    ('3', '2', 'ab+', '0123456787', 'Sumunica3', 'Velea', '0'),
                    ('4', '3', '0+' , '0123456786', 'Sumunica4', 'Andrei', '0'),
                    ('5', '1', '0-', '012345675', 'Sumunica5', 'Adiran', '1'),
                    ('6', '2', 'a+', '0123456784', 'Sumunica6', 'James', '0'),
                    ('7', '2', 'b-', '0123456783', 'Sumunica7', 'Mario', '0'),
                    ('8', '3', 'b-', '0123456782', 'Sumunica8', 'Maria', '1'),
                    ('9', '3', 'b+', '0123456781', 'Sumunica9', 'Alexandra', '1'),
                    ('10', '4', 'a-', '0123456780', 'Sumunica10', 'Marcel', '1');";

            return PopulateBloodBank +
                   PopulateDonors +
                   PopulateBloodBag +
                   PopulateVolunteers +
                   PopulatePacients;
        }

    }
}

