//module.exports = {
//  content: [
//    "./Views/**/*.cshtml",
//    "./Pages/**/*.cshtml",
//    "./wwwroot/**/*.js"
//  ],
//  theme: {
//    extend: {},
//  },
//  plugins: [],
//}

/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Views/**/*.cshtml",
        "./Pages/**/*.cshtml",
        "./wwwroot/**/*.js"
    ],
    theme: {
        extend: {
            fontFamily: {
                lato: ['Lato', 'sans-serif'],
                opensans: ['Open Sans', 'sans-serif']
            }
        }
    },
    plugins: [],
}
