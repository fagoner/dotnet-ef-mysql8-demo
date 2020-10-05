# DOTNET CORE  EF - Mysql8

Just a demo how to use EF/Mysql8 based on: [dev.mysql.ef.core](https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html)


## Usage

### Mysql8 - Docker 
You can use the resources on folder `docker-helper`
* set the database credentials in `docker-helper/stack.yml`
* run `./docker-helper/start.sh`, 
    * *this will run on background, to teardown use `./docker-helper/stop.sh`*

### DB  Connection String
* Set the connection string in the console application in `UserContext.cs`
* Replace `optionsBuilder.UseMySQL("server=localhost......")`  with your data


**...Happy coding**