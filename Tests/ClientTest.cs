using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HairSalon
{
  [Collection("HairSalonTests")]
  public class ClientTest : IDisposable
  {
    public ClientTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
    }

    public void Dispose()
    {
      Client.DeleteAll();
    }

    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
      int result = Client.GetAll().Count;

      Assert.Equal(0, result);
    }

    [Fact]
    public void Test_Equal_ReturnsTrueIfNamesAreTheSame()
    {
      Client firstClient = new Client("Person1", 1, "email");
      Client secondClient = new Client("Person1", 1, "email");
      Assert.Equal(firstClient, secondClient);
    }

    [Fact]
    public void Test_Save_SavesToDatabase()
    {
      Client testClient = new Client("Person1", 1, "email");
      testClient.Save();
      List<Client> result = Client.GetAll();
      List<Client> testList = new List<Client>{testClient};
      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_Save_AssignsIdToObject()
    {
      Client testClient = new Client("Person1", 1, "email");
      testClient.Save();
      Client savedClient = Client.GetAll()[0];
      int result = savedClient.GetId();
      int testId = testClient.GetId();
      Assert.Equal(testId, result);
    }

    [Fact]
    public void Test_Find_FindsClientInDatabase()
    {
      Client testClient = new Client("Pesron1", 1, "email");
      testClient.Save();
      Client foundClient = Client.Find(testClient.GetId());
      Assert.Equal(testClient, foundClient);
    }

    [Fact]
    public void Test_ByStylist_ReturnsTrueIfListsAreTheSame()
    {
      Stylist newStylist = new Stylist("A");
      Client firstClient = new Client("Person A", 1, "email", newStylist.GetId());
      Client secondClient = new Client("Person B", 2, "email", newStylist.GetId());
      newStylist.Save();
      firstClient.Save();
      secondClient.Save();
      List<Client> result = Client.ByStylist();
      List<Client> testList = new List<Client>{firstClient, secondClient};
      Assert.Equal(testList, result);
    }







  }
}
