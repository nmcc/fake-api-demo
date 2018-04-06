var path = require("path");
var apiMocker = require('connect-api-mocker');
var webpack = require('webpack');
var fs = require('fs');
var path = require('path');
var mkdirp = require('mkdirp');
var url = require('url');

module.exports = {
    entry: {
        app: ["./mock-webpack/main.js"]
    },
    output: {
        path: path.resolve(__dirname, "build"),
        publicPath: "/assets/",
        filename: "bundle.js"
    },
    devServer: {
        before(app) {
            app.use('/', apiMocker({
                target: 'mocks/',
                nextOnNotFound: true
            }));
        },
        proxy: {
            '/': {
                target: 'http://localhost:5454/',
                secure: false,
                changeOrigin: true,
                onProxyRes: function (proxyRes, req, res) {
                    console.log("Auto mocking call to ", req.url, "with request method ", req.method);
                    proxyRes.pipe(getMockFileStream(url.parse(req.url).pathname, req.method));
                    
                }
            }
        }
    }
};

function getMockFileStream(mockURLPathname, mockVerb) {
    var targetDirName = path.resolve(__dirname + '/mocks/' + mockURLPathname);
    var targetFilePath = path.resolve(targetDirName + '/GET.json'); // TODO: Change had code GET verb
    //console.log(targetFilePath);

    if (mockVerb === 'GET') {
        mkdirp.sync(targetDirName);
        var file = fs.openSync(targetFilePath, 'w');
        fs.closeSync(file);
        var stream = fs.createWriteStream(targetFilePath);
        return stream;
    }


}
