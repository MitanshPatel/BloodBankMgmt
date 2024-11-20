# Blood Bank Management

## Create
**POST /api/bloodbank**: Add a new entry to the blood bank list. The input should include donor details, blood type, quantity, and collection/expiration dates.

![Screenshot](img/post1.png)
![Screenshot](img/post1p.png)



## Read All
**GET /api/bloodbank**: Retrieve all entries in the blood bank list.

![Screenshot](img/get1.png)
![Screenshot](img/get1p.png)



## Read by ID
**GET /api/bloodbank/{id}**: Retrieve a specific blood entry by its Id.

![Screenshot](img/get2.png)
![Screenshot](img/get2p.png)



## Update
**PUT /api/bloodbank/{id}**: Update a specific blood entry by its Id. The input should include donor details, blood type, quantity, and collection/expiration dates.

![Screenshot](img/put1.png)
![Screenshot](img/put12.png)
![Screenshot](img/put1p.png)



## Delete
**DELETE /api/bloodbank/{id}**: Delete a specific blood entry by its Id.

![Screenshot](img/del1.png)
![Screenshot](img/del1p.png)



## Search by Blood Type
**GET /api/bloodbank/search?bloodType={bloodType}**: Retrieve all entries in the blood bank list with a specific blood type.

![Screenshot](img/get3.png)
![Screenshot](img/get3p.png)



## Search by Status
**GET /api/bloodbank/search?status={status}**: Search for blood bank entries by status (e.g., "Available", "Requested").

![Screenshot](img/get4.png)
![Screenshot](img/get4p.png)



## Search by Donor Name
**GET /api/bloodbank/search?donorName={donorName}**: Search for donors by name.

![Screenshot](img/get5.png)
![Screenshot](img/get5p.png)



## Pagination
**GET /api/bloodbank?page={pageNumber}&size={pageSize}**: Retrieve a paginated list of blood bank entries. The response should show entries based on page number and page size parameters.

![Screenshot](img/get6.png)
![Screenshot](img/get6p.png)


