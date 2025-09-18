<Query Kind="Statements">
  <Connection>
    <ID>f378e62e-aff4-4d72-94ce-f77a151624a4</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>StartTed-2025-Sept</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

// Question 1

ClubActivities
.Where(x => x.StartDate >= new DateTime(2025, 1, 1) && 
            x.CampusVenue.Location != "Scheduled Room" && 
            x.Name != "BTech Club Meeting")
.Select(x => new
{
    StartDate = x.StartDate,
    VenueName = x.CampusVenue.Location,
    ClubName = x.Club.ClubName,
    ActivityTitle = x.Name
})
.OrderBy(x => x.StartDate)
.Dump();