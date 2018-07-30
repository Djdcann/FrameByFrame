// Write your JavaScript code.
$(document).ready(function () {
    $('#fw').DataTable({
        "paging": false,
        "searching": true,
        "columns": [
            { "orderable": true, "type": "string" },
            { "orderable": true, "type": "num" },
            { "orderable": true, "type": "num" },
            { "orderable": true, "type": "string" }
        ],
        "order": [1, 'desc']
    });


});