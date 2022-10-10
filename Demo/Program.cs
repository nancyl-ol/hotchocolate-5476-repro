using Demo;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddMutationConventions(applyToAllMutations: true);

var app = builder.Build();

app.MapGraphQL();

app.Run();
