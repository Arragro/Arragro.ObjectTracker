﻿const path = require('path');
const glob = require('glob-all');
const webpack = require('webpack');
const UglifyJSPlugin = require('uglifyjs-webpack-plugin');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const CompressionPlugin = require("compression-webpack-plugin");

module.exports = (env) => {

    const isDevBuild = !(env && env.prod);

    let config = {
        devtool: 'source-map',
        resolve: {
            extensions: ['.js', '.jsx', '.ts', '.tsx']
        },
        module: {
            loaders: [
                {
                    test: /\.ts$/,
                    include: /app/,
                    exclude: [
                        /node_modules/,
                        /obj/
                    ],
                    use: [
                        { loader: 'babel-loader' },
                        { loader: 'ts-loader?silent=true' }
                    ]
                },
                { 
                    test: /\.scss?/, 
                    exclude: /node_modules/, 
                    use: [
                        //'css-hot-loader'                        
                    ].concat(ExtractTextPlugin.extract({ fallback: 'style-loader', use: ['css-loader', 'postcss-loader', 'sass-loader']}))
                },
                { test: /\.(png|woff|woff2|eot|ttf|svg)$/, loader: 'url-loader?limit=100000' },
                { test: /\.woff(\?\S*)?(\?v=[0-9]\.[0-9]\.[0-9])?$/, loader: 'url-loader?limit=10000&mimetype=application/font-woff' },
                { test: /\.(ttf|eot|svg)(\?\S*)(\?v=[0-9]\.[0-9]\.[0-9])?$/, loader: 'file-loader' }
            ]
        },
        entry: {
            main: ['./app/index.ts'],
            vendor: ['jquery', 'jquery-validation', 'jquery-validation-unobtrusive', 'bootstrap', 'popper.js']
        },
        output: {
            path: path.join(__dirname, 'wwwroot', 'dist'),
            filename: '[name].js',
            publicPath: '/dist/'
        },
        plugins: [
            new webpack.optimize.OccurrenceOrderPlugin(),
            new webpack.ProvidePlugin({
                $: "jquery",
                jQuery: "jquery",
                "window.jQuery": "jquery",
                Popper: ['popper.js', 'default']
            })
        ].concat(
            isDevBuild ? [
                new ExtractTextPlugin('main.css'),
                new webpack.optimize.CommonsChunkPlugin({ name: 'vendor', filename: 'vendor.js' })
            ] : [
                    new ExtractTextPlugin('main.css'),
                    new UglifyJSPlugin(),
                    new webpack.LoaderOptionsPlugin({
                        minimize: true,
                        debug: false
                    }),
                    new webpack.DefinePlugin({
                        'process.env.NODE_ENV': JSON.stringify(process.env.NODE_ENV || 'development')
                    }),
                    require('autoprefixer'),
                    new webpack.optimize.CommonsChunkPlugin({ name: 'vendor', filename: 'vendor.js' }),
                    new CompressionPlugin({
                        test: /\.(js|css)/
                    })
                ])
    };

    return config;
};