using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangriaHealthCenter
{
    class Queries
    {
        const String CreatePatientsTable = @"CREATE TABLE IF NOT EXISTS `Patients`( 
    v_id INT(6) UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    v_group VARCHAR(3) NOT NULL CHECK(v_group IN('0-', '0+', 'A-', 'A+', 'B-', 'B+', 'AB-', 'AB+')),
    emergency BOOLEAN NOT NULL DEFAULT FALSE,
    name VARCHAR(20) NOT NULL,
    surname VARCHAR(20) NOT NULL,
    phone VARCHAR(10) CHECK(NOT LIKE '%[^0-9]%'),
    hospital INT(6)
);";

    }
}
