module RecordDemo = 
    type ContactCard =
    {Name   : string
     Status : bool
     Age    : string}

    let myVal = 
    { Name = "VR"
      Status = False
      Age = "25"}

    printf "What is the" 
    
    let toStringRecord (c: ContactCard) = 
        c.Name + "is the Name " + (if c.Status then "Single" else "Married") + "is the Status" + c.Age

    let str = toStringRecord myVal

    printf "What is the : %s " str