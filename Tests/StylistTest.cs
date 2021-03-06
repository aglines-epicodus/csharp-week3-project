using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HairSalon
{
  [Collection("HairSalonTests")]
  public class StylistTest : IDisposable
  {
    public StylistTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_StylistTestEmptyAtFirst()
    {
      int result = Stylist.GetAll().Count;
      Assert.Equal(0, result);
    }

    [Fact]
    public void Test_Equal_ReturnsTrueForSameName()
    {
      Stylist firstStylist = new Stylist("StylistA", "a@b.com", "photolink here");
      Stylist secondStylist = new Stylist("StylistA", "a@b.com", "photolink here");
      Assert.Equal(firstStylist, secondStylist);
    }

    [Fact]
    public void Test_Save_SavesStylistToDatabase()
    {
      Stylist testStylist = new Stylist("StylistA", "a@b.com", "photolink here");
      testStylist.Save();
      List<Stylist> result = Stylist.GetAll();
      List<Stylist> testList = new List<Stylist>{testStylist};
      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_Save_AssignsIdToStylistObject()
    {
      Stylist testStylist = new Stylist("StylistA", "a@b.com", "photolink here");
      testStylist.Save();
      Stylist savedStylist = Stylist.GetAll()[0];
      int result = savedStylist.GetId();
      int testId = testStylist.GetId();
      Assert.Equal(testId, result);
    }

    [Fact]
    public void Test_Find_FindsStylistInDatabase()
    {
      Stylist testStylist = new Stylist("StylistA", "a@b.com", "photolink here");
      testStylist.Save();
      Stylist foundStylist = Stylist.Find(testStylist.GetId());
      Assert.Equal(testStylist, foundStylist);
    }


//  MOVED HERE FROM CLIENTTEST.CS FOR RESUBMISSION
    [Fact]
    public void Test_ByStylist_ReturnsTrueIfListsAreTheSame()
    {
      Stylist newStylist = new Stylist("A", "a@a.com", "photolink");
      Client firstClient = new Client("Person A", 1, "email", newStylist.GetId());
      Client secondClient = new Client("Person B", 2, "email", newStylist.GetId());
      newStylist.Save();
      firstClient.Save();
      secondClient.Save();
      List<Client> result = Client.ByStylist();
      List<Client> testList = new List<Client>{firstClient, secondClient};
      Assert.Equal(testList, result);
    }

    public void Dispose()
    {
      Stylist.DeleteAll();
    }


  }
}
