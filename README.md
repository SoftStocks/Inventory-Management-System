<!DOCTYPE html>
  <html>
  <!--
  <img alt="SOFTSTOCKS-LOGO" src="https://user-images.githubusercontent.com/122273108/212332116-eb8fd1c3-b45f-4680-8995-93b7faf6610d.png">
  -->
  <img alt="SOFTSTOCKS-LOGO" src="SoftStocks/SoftStocksGUI/Resources/backpack.png" width=100 height=100>
  <hr>
  <h2>
    <em>SoftStocks</em>
    <br>
    <em>What do you call humorous inventory? A Laughing Stock</em>
  </h2>
  <h2>Description</h2>
  <p>
    <strong>SoftStocks</strong> makes looking after your Inventory Stock as easy as clicking a few buttons. SoftStocks will keep tabs on the stock levels and stock distributors so that you can always see all of your businesses data all in one place.
    We put our complete trust in our software to keep your data safe and secure, our authentication system will only allow registered and authenticated users from viewing, deleting and editing data.
  </p>
  <h2>Usage</h2>
  <p>With an easy to use user interface, built around being clean and ituitive we believe that this system is very straight forward. Once run there will be a start up log in screen presented to the user where to access any other pages they will have to sign in with their credentials. After logged in you can access three different pages, Home, Edit and Advanced. The home page serves all supplier infomation and controls to be able to add, edit and delete different entries.
  </p>
  
  <h3>Report</h3>
  <p><code>Report</code> is the unit of information within SoftStocks. It is an object with which the client interacts via application logic.</p>
  <p>Architecturally, this is a read-only layer that makes use of Entity Framework, which in turn makes use of the database. The implementation details of connecting to the database and using <code>DbContext</code> are abstracted away from the client.</p>
  <p>Whilst <code>Report</code> itself is an abstract class, the following guide can be used for any class which implements <code>Report</code>:</p>
  
  <h4>Constructor</h4>
  
  <code> Report report = new Report(id)</code>
  <p>A new report can be created by using constructor, with one parameter corresponding to the id of the report's respective entity in the database. Reports will present information derived from a single record, with <code>id</code> specifying which record.</p>
  <p>NB: the code above will not work, as it references an abstract class. There will be other types of report implementing this class, but all will have the same behaviours as the base class.</p>
  
  <code>report.Generate(ReportFormat.Pdf)</code>
  <p>Part of <code>Report</code> is the ability to render data in a given format. These formats are contained within the enum at <code>ReportFormat.cs</code>. This is a method within the abstract definition of <code>Report</code>, with the implementation details altering based on the type of report being generated.
  
  <code>report.Destroy()</code>
  <p>The report's entry within persistent object storage will be removed, along with any associated files.</p>

</html>  
