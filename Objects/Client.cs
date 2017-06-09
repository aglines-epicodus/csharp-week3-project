using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace HairSalon
{
  public class Client
  {
    private int _id;
    private string _name;
    private int _stylistId;
    private string _contact;

    public Client(string Name, int StylistId, string Contact, int Id = 0)
    {
      _id = Id;
      _name = Name;
      _stylistId = StylistId;
      _contact = Contact;
    }
    public int GetId()
      {
        return _id;
      }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetStylistId()
    {
      return _stylistId;
    }
    public void SetStylistId(int newStylistId)
    {
      _stylistId = newStylistId;
    }
    public string GetContact()
    {
      return _contact;
    }
    public void SetContact(string newContact)
    {
      _contact = newContact;
    }

    public override bool Equals(System.Object otherClient)
    {
      if (!(otherClient is Client))
      {
        return false;
      }
      else
      {
        Client newClient = (Client) otherClient;
        bool idEquality = (this.GetId() == newClient.GetId());
        bool nameEquality = (this.GetName() == newClient.GetName());
        bool stylistIdEquality = this.GetStylistId() == newClient.GetStylistId();
        bool contactEquality = this.GetContact() == newClient.GetContact();
        return (idEquality && nameEquality && stylistIdEquality && contactEquality);
      }
    }

    public static List<Client> GetAll()
    {
      List<Client> allClients = new List<Client> {};

      SqlConnection conn = DB.Connection();
      conn.Open();

      SqlCommand cmd = new SqlCommand("SELECT * FROM clients;", conn);
      SqlDataReader rdr = cmd.ExecuteReader();

      while(rdr.Read())
      {
        int clientId = rdr.GetInt32(0);
        string clientName = rdr.GetString(1);
        int clientStylistId = rdr.GetInt32(2);
        string clientContact = rdr.GetString(3);
        Client newClient = new Client(clientName, clientStylistId, clientContact, clientId);
        allClients.Add(newClient);
      }

      if (rdr != null)
      {
        rdr.Close();
      }
      if (conn != null)
      {
        conn.Close();
      }
      return allClients;
    }

    public static void DeleteAll()
    {
      SqlConnection conn = DB.Connection();
      conn.Open();
      SqlCommand cmd = new SqlCommand("DELETE FROM clients;", conn);
      cmd.ExecuteNonQuery();
      conn.Close();
    }
  }
}
