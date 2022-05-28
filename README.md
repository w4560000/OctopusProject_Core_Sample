OctopusProject_Core_Sample

```CMD
# Build Docker Image 
docker build -t octopusproject_core_sample --build-arg ProjectName=OctopusProject_Core_Sample --no-cache .

# run with appsettings.develop.json 
docker run -d --rm --name octopusproject_core_sample.container -p 8080:80 -e ASPNETCORE_ENVIRONMENT=develop octopusproject_core_sample

# run with appsettings.json 
docker run -d --rm --name octopusproject_core_sample.container -p 5000:80 octopusproject_core_sample

# test
curl 127.0.0.1:8080/Home/GetEnv
curl 127.0.0.1:8080/Home/Test
```