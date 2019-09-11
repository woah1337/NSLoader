/*credits to SKLabs for this
works with invision power suite*/
<?php

$_SERVER['SCRIPT_FILENAME']    = __FILE__;
require_once 'init.php';

$init = \IPS\Session\Front::i();

$username = $_GET['username'];
$password = $_GET['password'];
$hwid = $_GET['hwid'];

$table = 'core_members';

$query = \IPS\Db::i()->select( '*', $table, 'name=' . "'$username'")->query;
$result = \IPS\Db::i()->query($query)->fetch_assoc();
$id = $result["member_id"];
$set_hwid = $result["hwid"];

$member = \IPS\Member::load($id);

if ($member->name != $username) {
    die();
}

if (password_verify($password , $member->members_pass_hash ) !== TRUE) {
    echo "p0<br>";
    die();
}

echo "p1<br>";

$primary_group = $member->member_group_id;
$secondary_groups = explode(',', $member->mgroup_others);

echo "g$primary_group <br>";

if (strlen($set_hwid) > 1)
{
    if ($hwid != $set_hwid)
        echo "h0<br>";
    
    else
        echo "h1<br>";
}

else
{
    $query_worked = \IPS\Db::i()->update( "$table", array( 'hwid' => "$hwid" ), array( 'name=?', $username ) );

    if($query_worked)
    {
        echo "h3<br>"; //for setting new hwid
    }
    else
    {
        echo "h0<br>";
    }
}

?>
