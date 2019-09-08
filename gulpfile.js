const gulp = require('gulp');
const zip = require('gulp-zip');
const fileindex = require('gulp-fileindex');

gulp.task('fileindex', function(){
	return gulp.src('ar/dist/*.zip')
		.pipe(fileindex())
		.pipe(gulp.dest("./ar/dist"));
});

gulp.task('zipper', function(){
	return gulp.src('ServiciosWeb/*')
		.pipe(zip('Artefacto_SA_Tarea6.zip'))
		.pipe(gulp.dest('ar/dist'));
});

gulp.task('default', gulp.series('zipper', 'fileindex'));