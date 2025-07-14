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
            keyframes: {
                'fade-in-up': {
                    '0%': { opacity: '0', transform: 'translateY(20px)' },
                    '100%': { opacity: '1', transform: 'translateY(0)' },
                },
                'scale-in': {
                    '0%': { opacity: '0', transform: 'scale(0.95)' },
                    '100%': { opacity: '1', transform: 'scale(1)' },
                }
            },
            animation: {
                'fade-in-up': 'fade-in-up 0.6s ease-out forwards',
                'scale-in': 'scale-in 0.4s ease-out forwards'
            }
        }
    },
    plugins: []
}
