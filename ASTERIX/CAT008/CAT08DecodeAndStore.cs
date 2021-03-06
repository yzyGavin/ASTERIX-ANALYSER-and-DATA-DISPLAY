﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsterixDisplayAnalyser
{
    class CAT08DecodeAndStore
    {
        // This method will accept a buffer of data with the assumption that 
        // category has been determined. It will then decode the data and save 
        // it in the shared buffer. Everry time a message is passed in the data 
        // will be appended to the buffer. This means that each line will contain 
        // data for one message. For data items which are not in the message,
        // indicated by the FSPEC field, N/A will be inserted instead. The shared 
        // buffer is loacted in the SharedData and will not be saved. It is responsibility
        // of the user to save the data in a file it desired.
        public static void Do(byte[] Data)
        {

            // I008/000, Message Type  
            // I008/010, Data Source Identifier  
            // I008/020, Vector Qualifier 
            // I008/034, Sequence of Polar Vectors in SPF Notation  
            // I008/036, Sequence of Cartesian Vectors in SPF Notation  
            // I008/038, Sequence of Weather Vectors in SPF Notation  
            // I008/040, Contour Identifier 
            // I008/050, Sequence of Contour Points in SPF Notation  
            // I008/090, Time of Day  
            // I008/100, Processing Status 
            // I008/110, Station Configuration Status  
            // I008/120, Total Number of Items Constituting One Weather Picture  

            
        }
    }
}
