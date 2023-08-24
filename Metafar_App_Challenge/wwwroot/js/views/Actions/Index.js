$(document).ready(function () {
    const favData = getParamFavoriteData();
    const paramData = getParamActionsData();
    let favUrl = `/Actions/GetFavoriteTableData?${$.param(favData)}`;
    let actionUrl = `/Actions/GetActionsTableData?${$.param(paramData)}`;
    $('#favorite-Table').DataTable({
        ajax: {
            url: favUrl,
            type: 'POST',
            dataSrc: 'data'
        },
        paging: true,
        serverSide: true,
        columns: [
            { data: 'symbol' },
            { data: 'name' },
            { data: 'currency' },
            { data: 'delete' }
        ],
    });

    $('#actions-Table').DataTable({
        ajax: {
            url: actionUrl,
            type: 'POST',
            dataSrc: 'data'
        },
        paging: true,
        serverSide: true,
        columns: [
            { data: 'asymbol' },
            { data: 'aname' },
            { data: 'acurrency' },
            { data: 'favorite' }
        ],
    });
});

const getParamFavoriteData = () => {
    let data = {
        //collect userId
        //'userId': $('select#action_name').val()
    }
    return data;
}

const getParamActionsData = () => {
    let data = {
        'nameFilter': $('select#action_name').val(),
        'symbolFilter': $('select#action_symbol').val()
    }
    return data;
}