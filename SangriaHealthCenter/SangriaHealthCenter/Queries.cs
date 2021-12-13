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
                v_id INT(6) UNSIGNED NOT NULL PRIMARY KEY,
                role VARCHAR(3) CHECK(role AS('FB','IG','FLY','ADS')),    
                phone VARCHAR(10) NOT NULL,    
                name VARCHAR(20) NOT NULL,    
                surname VARCHAR(20) NOT NULL,    
                bloodbank INT(6) NOT NULL);";

        const String CreateTableDonors =
            @"CREATE TABLE IF NOT EXISTS Donors(	
                d_id INT(6) UNSIGNED NOT NULL PRIMARY KEY,
                regular BOOLEAN,
                phone VARCHAR(10) NOT NULL,
                b_group VARCHAR(3) NOT NULL CHECK(b_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')),
          			email VARCHAR(30) NOT NULL,
                name VARCHAR(20) NOT NULL,
                surname VARCHAR(20) NOT NULL,
                bloodbank INT(6) NOT NULL);";
        
        const String CreateTablePatients =
          @"CREATE TABLE IF NOT EXISTS `Patients`( 
                p_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
                p_group VARCHAR(3) NOT NULL CHECK(v_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')),
                emergency BOOLEAN NOT NULL DEFAULT FALSE,
                name VARCHAR(20) NOT NULL,
                surname VARCHAR(20) NOT NULL,
                phone VARCHAR(10) CHECK(NOT LIKE '%[^0-9]%'),
                hospital INT(6));";

    }
}
