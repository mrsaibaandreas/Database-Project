using System;


namespace SangriaHealthCenter
{
    class Queries
    {
        // CREATING TABLES

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
                bloodbank INT(6) UNSIGNED NOT NULL);";
        
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
                inventory INT(6) UNSIGNED NOT NULL);";

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
                hospital INT(6) UNSIGNED NOT NULL,
                laboratory INT(6) UNSIGNED NOT NULL);";

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
                inventory INT(6) UNSIGNED NOT NULL,
                hospital INT(6) UNSIGNED NOT NULL);";


        //CREATE FOREIGN KEYS

        const String FkPatientInHospital =
            @"ALTER TABLE Patients
                ADD CONSTRAINT fk_patient_in_hospital
                FOREIGN KEY (hospital) 
                REFERENCES Hospital(h_id) 
                ON DELETE CASCADE;";

        const String FkVolunteerInBloodbank =
            @"ALTER TABLE Volunteers
                ADD CONSTRAINT fk_volunteer_at_bloodbank
                FOREIGN KEY (bloodbank) 
                REFERENCES BloodBank(b_id) 
                ON DELETE CASCADE;";

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
                ON DELETE CASCADE;";

        const String FkLaboratoryOfHospital =
            @"ALTER TABLE Laboratory
                ADD CONSTRAINT fk_laboratory_in_hospital
                FOREIGN KEY (hospital) 
                REFERENCES BloodBank(b_id) 
                ON DELETE CASCADE;";

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
                ON DELETE CASCADE;";

        const String FkMedicalstaffOfHospital =
            @"ALTER TABLE MedicalStaff
                ADD CONSTRAINT fk_medicalstaff_of_hospital
                FOREIGN KEY (hospital) 
                REFERENCES Hospital(h_id) 
                ON DELETE CASCADE;";

        const String FkMedicalstaffOfLaboratory =
            @"ALTER TABLE MedicalStaff
                ADD CONSTRAINT fk_medicalstaff_of_laboratory
                FOREIGN KEY (laboratory) 
                REFERENCES Laboratory(l_id) 
                ON DELETE CASCADE;";

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

        public String DropTables() 
        {
            String dropTables =
                @"DROP TABLE `Volunteers`, `Patients`, `MedicalStaff`, `Laboratory`, 
                `Inventory`, `Hospital`, `Donors`, `BloodBank`, `BloodBag`;";

            return dropTables;
        }

        public String InitTablesQueries()
        {
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

    }
}
    
