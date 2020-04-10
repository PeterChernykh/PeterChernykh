$(function () {
	var target = $('[data-field="target"]');

	$(document).on('input', '[data-field="item"]', function () {
		var item = $(this);

		target.html(item.val().length);
	});
});