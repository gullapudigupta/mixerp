function initialiseDateFunctions(datepickerID) {
    var start = moment().subtract(29, 'days');
    var end = moment();
    function cb(start, end) {
        $('#drp_autogen0 span').html('');
        $('#drp_autogen0 span').html(start.format('MMM D, YYYY') + ' - ' + end.format('MMM D, YYYY'));

       // datepickerID.val(start.format('MMM D, YYYY') + ' - ' + end.format('MMM D, YYYY'));
    }

    //  $('#' + datepickerID + '\'').daterangepicker({
    datepickerID.daterangepicker({
        locale: {
            format: 'MM/DD/YYYY'
        },
        startDate: start,
        endDate: end,
        ranges: {
            'Today': [moment(), moment()],
            'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
            'Last 7 Days': [moment().subtract(6, 'days'), moment()],
            'Last 30 Days': [moment().subtract(29, 'days'), moment()],
            'This Month': [moment().startOf('month'), moment().endOf('month')],
            'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
        }
    }, cb);

    cb(start, end);
}

function getStartEndDate(datepickerID)
{

    // var d = $('#' + datepickerID + '\'').val();
    var d = datepickerID.val();
    
    var errorLevel = $('#errorLevel').val();
    var campaignId = $('#campaignId').data('cid');
    var start = '';
    var end = '';


    if (d) {
        moment().format('MM/DD/YYYY')
        var dateInfo = JSON.parse(d);
        start = moment(dateInfo.start).format('MM/DD/YYYY');
        end = moment(dateInfo.end).format('MM/DD/YYYY');
    }

    return {
        start: start,
        end:end    
        }
}