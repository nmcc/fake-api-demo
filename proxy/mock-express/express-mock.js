var express = require('express');
var apiMocker = require('connect-api-mocker');
var fs = require('fs');
var path = require("path");
var mkdirp = require('mkdirp');

 
var app = express();

// var restMock = apiMocker('/api', 'mocks/api');
var restMock = apiMocker('/api', {
    target: 'mocks/v1',
    nextOnNotFound: true
});

app.use(restMock);

// respond with "hello world" when a GET request is made to the homepage
app.get('/', function (req, res) {
    res.send('hello world')
});


// respond with "hello world" when a GET request is made to the homepage
app.get('/tst', function (req, res) {
    console.log("Request URL: ", req.url, "with verb", req.method);
    var data = "{ 'some': 'test' }";
    data = data.toString('utf-8');
    console.log(data);
    createMockFile(req.url, req.method, data);
    res.send(data);
});

function createMockFile(mockURL, mockVerb, mockContent) {
    var targetDirName = path.resolve(__dirname + '/../mocks-tst/' + mockURL);
    var targetFilePath = path.resolve(targetDirName + '/GET.json'); // TODO: Change had code GET verb
    console.log(targetFilePath);


    mkdirp(targetDirName, function (err) {
        if (err) throw err;
        fs.writeFile(targetFilePath, mockContent, function (err) {
            if (err) throw err;

        });
    });

}

console.log("Mock server started");
app.listen(8080);