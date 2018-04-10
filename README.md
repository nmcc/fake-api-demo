# Fake API Demo

This repo contains a demo for Fake Web APIs.

It includes demos of two types of Fakes:

* Proxy fake
* Stateful API Fake

# Repo structure
* `ui/` - Web Application with HTML interface; makes calls the Web API project
* `web-api/` - Web API that provides business logic for the Web UI
* `proxy/` - Contains the proxy fake project
* `fake-api/` - Contains the Fake API project
* `nswag/` - Contains the files related to NSwag and code generation


# Proxy Fake

First run
```
cd proxy/
npm install
```

Running the proxy
```
npm run start:webpack
```

## Build docker image
(not working proppely yet)

Building the Docker image

```
cd fake-api
docker build . -t movie-rating-api-fake:1.0
```

Running the docker image
```
docker run movie-rating-api-fake:1.0 -p 8080:80
```

# Generating code

The `nswag/` directory includes a NSwag project that generates code from the Web API:

* __C# Client__: Generates the client stubs for invoking the Web API. The generated classes are used by the Web UI application to make calls to the Web API
* __MVC Web API Controllers__: Generates Controller classes to be implemented at the Fake API project

## Generating code from the NSwag project
* Install NSwag Studio
* Open the `nswag/MovieRatingAPI.nswag` project
* Client "Generate files" button

## Generating the code from the command line
```
$ cd nswag
$ .\generate_mocks.bat
```