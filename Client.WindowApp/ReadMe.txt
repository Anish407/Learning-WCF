1. To add metadata, Add a behavior in the host
 <serviceMetadata httpGetEnabled="true"></serviceMetadata>
 also the host section
  <host>
          <baseAddresses>
            <add baseAddress="http://localhost:8080"/>
          </baseAddresses>
        </host>
This will expose the service as an http url.
We can then add a service reference in the client to generate the service contract and the data contracts automatically using VS.

Run VS as an Admin, Run the host. Add add the host as a service reference in the Client. Enter the url while adding the service reference,
and click OK. 
