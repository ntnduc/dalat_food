/* eslint-disable*/
const { createProxyMiddleware } = require("http-proxy-middleware");

module.exports = function(app) {
    app.use(
        '/beverages',
        createProxyMiddleware({
            target: 'https://beverages-and-desserts.p.rapidapi.com',
            changeOrigin: true,
        })
    );
};