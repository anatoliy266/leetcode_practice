import pandas as pd

def trips_and_users(trips: pd.DataFrame, users: pd.DataFrame) -> pd.DataFrame:
    banned_users = users[users['banned'] == 'Yes']['users_id']

    df = trips[
        (~trips['client_id'].isin(banned_users)) & 
        (~trips['driver_id'].isin(banned_users)) &
        (trips['request_at'].between('2013-10-01', '2013-10-03'))
    ]

    df['is_cancelled'] = df['status'].str.startswith('cancelled').astype(int)

    res = df.groupby('request_at')['is_cancelled'].mean().reset_index()
    res.columns = ['Day', 'Cancellation Rate']
    res['Cancellation Rate'] = res['Cancellation Rate'].round(2)

    return res