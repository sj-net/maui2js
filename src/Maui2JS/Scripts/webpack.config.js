const path = require('path');

module.exports = {
    entry: './src/index.ts',
    devtool: 'source-map',
    output: {
        filename: 'maui2js.v1.min.js',
        path: path.resolve(__dirname, '../wwwroot/js/'),
        library: 'maui2js', // Name of the global variable
        libraryTarget: 'var', // Use 'var' to attach to a variable
        clean: true,
    },
    resolve: {
        extensions: ['.ts', '.js'],
    },
    module: {
        rules: [
            {
                test: /\.ts$/,
                use: 'ts-loader',
                exclude: /node_modules/,
            },
        ],
    },
    mode: 'production',
};
