import * as React from 'react';
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import CssBaseline from '@mui/material/CssBaseline';

import Toolbar from '@mui/material/Toolbar';
import List from '@mui/material/List';

import Divider from '@mui/material/Divider';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import InboxIcon from '@mui/icons-material/MoveToInbox';
import { useNavigate } from 'react-router-dom';

const drawerWidth = 240;

export default function SideNav() {
    const navigate=useNavigate();
  return (
    <Box sx={{ display: 'flex' }}>
      <CssBaseline />
      <Drawer
        sx={{
          width: drawerWidth,
          flexShrink: 0,
          '& .MuiDrawer-paper': {
            width: drawerWidth,
            boxSizing: 'border-box',
          },
        }}
        variant="permanent"
        anchor="left"
      >
        <Toolbar />
        <Divider />
        <List>
          {/* {['Home', 'About', 'Settings'].map((text, index) => ( */}
            <ListItem  disablePadding>
              <ListItemButton>
                <ListItemIcon>
                  <InboxIcon /> 
                </ListItemIcon>
                <ListItemText primary="Homes"  onClick={()=>{navigate("/")}} />
              </ListItemButton>
            </ListItem>
            <ListItem  disablePadding>
              <ListItemButton>
                <ListItemIcon>
                  <InboxIcon /> 
                </ListItemIcon>
                <ListItemText primary="About" onClick={()=>{navigate("/about")}} />
              </ListItemButton>
            </ListItem>
            <ListItem  disablePadding>
              <ListItemButton>
                <ListItemIcon>
                  <InboxIcon /> 
                </ListItemIcon>
                <ListItemText primary="Settings" onClick={()=>{navigate("/settings")}} />
              </ListItemButton>
            </ListItem>
          {/* ))} */}
        </List>
        <Divider />
        {/* <List>
          {['Categories', 'Favourities', 'Deleted'].map((text, index) => (
            <ListItem key={text} disablePadding>
              <ListItemButton>
                <ListItemIcon>
                  {index % 2 === 0 ? <InboxIcon /> : <MailIcon />}
                </ListItemIcon>
                <ListItemText primary={text} />
              </ListItemButton>
            </ListItem>
          ))}
        </List> */}
      </Drawer>
      <Box
        component="main"
        sx={{ flexGrow: 1, bgcolor: 'background.default', p: 3 }}
      >
        <Toolbar />
        
        
      </Box>
    </Box>
  );
}