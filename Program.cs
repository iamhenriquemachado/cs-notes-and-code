using cs_notes_and_code.challenges.Day_21_22.FuncEventHandler;

string[] rawVehiclePayload = new string[] { 

    "Toyota,Corolla,2015,45000,True",
    "Ford,Focus,2008,120000,True",     
    "Toyota,Hilux,2018,60000,True",
    "Chevrolet,Onix,2020,15000,True",
    "Ford,Ranger,2019,35000,False",     
    "INVALID_DATA_LINE_WITHOUT_COMMAS",
    "Chevrolet,Cruze,2017,40000,True"
};


FleetProcessor processor = new FleetProcessor();

processor.RawDataParser(rawVehiclePayload);

