init();
function init() {
    LoadTableCategory();
}
function LoadTableCategory() {
    var table = $('#tbCategory').DataTable({
        "bDestroy": true,
        "processing": true,
        "serverSide": true,
        "ajax": {
            "url": "/Category/GetAllCategory",
            "type": "POST",
            "data": function (d) {
                return $.extend({}, d, {
                });
            },
        },

        "columns": [
            { "data": "ID", width: '10%' },
            { "data": "Name", width: '20%' },
            { "data": "Picture", width: '10%' },
            { "data": "ShowOnHome", width: '10%' },
            { "data": "DisplayOrder", width: '10%' },
            {
                "data": "CreatedOnUtc",
                width: '5%',
                'render': function (data, type, full, meta) {
                    var html = convertDatetime(full.CreatedOnUtc);
                    return html;
                }
            },
            {
                "data": "UpdateOnUtc",
                width: '5%',
                'render': function (data, type, full, meta) {
                    var html = convertDatetime(full.UpdateOnUtc);
                    return html;
                }
            },



        ],
        "paging": true,
        "lengthChange": true,
        "searching": false,
        "ordering": true,
        "info": true,
        "autoWidth": false
    });

}