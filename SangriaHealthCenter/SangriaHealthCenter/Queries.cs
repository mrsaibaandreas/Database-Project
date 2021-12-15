using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                bloodbank INT(6) UNIGNED NOT NULL);";

        const String CreateTableDonors =
            @"CREATE TABLE IF NOT EXISTS Donors(	
                d_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
                regular BOOLEAN,
                phone VARCHAR(10) NOT NULL,
                b_group VARCHAR(3) NOT NULL CHECK(b_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')),
          			email VARCHAR(30) NOT NULL,
                name VARCHAR(20) NOT NULL,
                surname VARCHAR(20) NOT NULL,
                bloodbank INT(6) UNSIGNED NOT NULL);";
        
        const String CreateTablePatients =
          @"CREATE TABLE IF NOT EXISTS `Patients`( 
                p_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
                b_group VARCHAR(3) NOT NULL CHECK(b_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')),
                emergency BOOLEAN NOT NULL DEFAULT FALSE,
                name VARCHAR(20) NOT NULL,
                surname VARCHAR(20) NOT NULL,
                phone VARCHAR(10) NOT NULL,
                hospital INT(6) UNSIGNED NOT NULL);";

        const String CreateTableBloodbank =
            @"CREATE TABLE IF NOT EXISTS Bloodbank(
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
                role VARCHAR(6) NOT NULL CHECK(role IN('doctor','nurse')
                expenses FLOAT(6,2) NOT NULL
                hospital INT(6) UNSIGNED NOT NULL
                laboratory INT(6) UNSIGNED NOT NULL);";

        public String InitTablesQueries()
        {
            String initQueries = CreateTableVolunteers + 
                                CreateTableDonors + 
                                CreateTablePatients;

            return initQueries;
        }

    }
}
