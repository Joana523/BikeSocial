using BikeSocialDTOs;
using BikeSocialEntities;
namespace BikeSocialBLL.Extensions;

public static class Extensions
{
    //public static User AsUserDto(this GetUserDto gud)
    //{
    //    return new User(gud.username, gud.password);
    //}

    public static Trainings AsTraining(this CreateTrainingDto trainingDto)
    {
        Trainings train = new();

        train.name = trainingDto.name;
        train.dateTime = trainingDto.dateTime;
        train.EstimatedTime = trainingDto.estimatedTime;
        train.Distance = trainingDto.distance;
        train.PlaceId = trainingDto.placeId;
        train.TrainingTypeId = trainingDto.trainingTypeId;
        train.PlanId = trainingDto.planId;

        return train;
    }

    
    public static Race AsRace(this CreateRaceDto raceDto)
    {
        Race race = new();

        race.Description = raceDto.description;
        race.Distance = raceDto.distance;
        race.EstimatedTime = raceDto.estimatedTime;
        race.dateTime = raceDto.dateTime;
        race.FederationId = raceDto.FederationId;
        race.RaceTypeId = raceDto.RaceTypeId;
        race.PlaceId = raceDto.placeId;

        return race;
    }

    public static Route AsRoute(this CreateRouteDto createRouteDto)
    {
        Route route = new();

        route.userId = createRouteDto.userId;
        route.description = createRouteDto.Description;
        route.placeId = createRouteDto.placeId;
        route.routeTypeId = createRouteDto.routeTypeId;
        route.dateTime = createRouteDto.dateTime;
        route.estimatedTime = createRouteDto.estimatedTime;
        route.distance = createRouteDto.distance;

        return route;

    }
    
    public static Athlete AsAthlete(this CreateAthleteDto athleteDto)
    {
        Athlete athlete = new();

        athlete.name = athleteDto.name;
        athlete.Distance = athleteDto.distance;
        athlete.EstimatedTime = athleteDto.estimatedTime;
        athlete.dateTime = athleteDto.dateTime;
        athlete.FederationId = athleteDto.FederationId;
        athlete.RaceTypeId = athleteDto.RaceTypeId;
        athlete.PlaceId = athleteDto.placeId;

        return athlete;
    }
}