// Encapsulation using properties
public class Account {
  private string accoutName = "SAVING_ACCOUNT";
  
  // property which has get and set
  public string AccoutName {
    get {
      return accoutName;
    }
    set {
      accoutName = value;
    }
  }
  private string address = "NPL";
  
  // readonly property
  public string Address {
    get {
      return address;
    }
  }
  
  private string phone = "1234567890";
  
  // writeonly property
  public string Phone {
    set {
      phone = value;
    }
  }
}
static void Main() {

  // Encapsulation using properties
  string name = string.Empty;
  Account account = new Account();
  
  // call get part
  name = account.AccoutName;
  
  // change the value
  name = "CURRENT_ACCOUNT";
  
  // call set part
  account.AccoutName = name;
  string address = string.Empty;
  
  // call readonly property
  address = account.Address;  // now address has value "NPL"
 
  string phone = "1234567890";
  
  // call writeonly property
  account.Phone = phone; // now account.Phone has value "1234567890"
}
