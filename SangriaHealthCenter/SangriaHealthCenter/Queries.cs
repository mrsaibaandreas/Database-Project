using System;


namespace SangriaHealthCenter
{
    class Queries
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
                item VARCHAR(20));";

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
                donor INT(6) NOT NULL, 
                bloodbank INT(6) NOT NULL);";

        const String CreateTableLaboratory =
            @"CREATE TABLE IF NOT EXISTS Laboratory(
	            l_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY ,
	            address VARCHAR(50) NOT NULL,
                bloodbank INT(6) UNSIGNED NOT NULL,
                inventory INT(6) UNSIGNED NOT NULL,
                hospital INT(6) UNSIGNED NOT NULL);";

        const String CreateTableLaboratory = 
            @"CREATE TABLE IF NOT EXISTS Laboratory( 
                l_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,  
                address VARCHAR(50) NOT NULL,
                bloodbank_id INT(6) NOT NULL,
                inventory_id INT(6) NOT NULL, 
                hospital_id INT(6) NOT NULL );";

        const String CreateTableBloodBag =
            @"CREATE TABLE IF NOT EXISTS BloodBag( 
                bb_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
                bloodbank_id INT(6) UNSIGNED NOT NULL,
                bb_group VARCHAR(3) NOT NULL CHECK(bb_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')),
                content VARCHAR(1) NOT NULL CHECK(content IN('B','T','P')),
                donor_id INT(6) UNSIGNED NOT NULL );";


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

    }
}
    