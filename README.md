# Jwelry-Store
This solution is developed by unsing the technologies
	1. Dotnet core 5
	2. Angular 11
	3. MS SQL Server 2016
	4. JWT Token
	5. Swagger UI for testing
	
Instructions to run this application
	1. Restore database in SQL Server 2016 shared in the file
	2. Change connection string  in appsetting file of API as per your database conLogin nection string
	3. Create user  by invoking User/CreateUser end point from swagger UI or use defaut user(for Privileged user=rich@gmail.com & Pass=rich@12345) && 
		(for Normal user=richa@gmail.com & Pass=richa@12345)
	4. Get tocken by invoking the User/ Logn end point and provide user credentials
	5. Once the token generated then use that in Swagger UI Authorize option to set the token for each end point
		example:In Authorize text box type Bearer and then generated token
				
				Like, Bearer xcvbnghfghkfhdgfhghklgjfhghlgkfhd
	
	
