const browserSync = require('browser-sync');
var gulp = require('gulp');
var concat = require('gulp-concat');
var cssmin = require('gulp-cssmin');
var uncss = require('gulp-uncss');
var bs = require('browser-sync').create();

gulp.task("browserSync", () => {
    bs.init({
        proxy: "localhost:5001"
    });

    gulp.watch("./wwwroot/css/**/*.css", gulp.series('css'));
    gulp.watch("./wwwroot/js/**/*.js", gulp.series('js'));
})

gulp.task('js', () => {
    return gulp.src(['./node_modules/bootstrap/dist/js/bootstrap.min.js',
                     './node_modules/jquery/dist/jquery.min.js',
                     './node_modules/jquery-validation/dist/jquery.validate.min.js',
                     './node_modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js'])
                     .pipe(gulp.dest('./wwwroot/js/'))
                     .pipe(browserSync.stream());;
})

gulp.task('css', () => {
    return gulp.src(['./node_modules/bootstrap/dist/css/bootstrap.css'])
    // .pipe(concat("site.min.css"))
    .pipe(cssmin())
    .pipe(uncss({html: ["Views/**/*.cshtml"]}))
    .pipe(gulp.dest('./wwwroot/css/'))
    .pipe(browserSync.stream());
})

gulp.task('watch-css', () => {
    gulp.watch("./wwwroot/css/**/*.css", gulp.series('css'));
})

gulp.task('watch-js', () => {
    gulp.watch("./wwwroot/js/**/*.js", gulp.series('js'));
})
